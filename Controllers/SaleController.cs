using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using profisee_project.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace profisee_project.Controllers
{
    public class SaleController : Controller
    {
        private readonly MainDataBaseContext _dbContext;

        public SaleController(MainDataBaseContext context)
        {
            _dbContext = context;
        }

        public List<Sale> GetSales<Sale>() where Sale : class
        {  
            {
                return _dbContext.Set<Sale>().ToList();
            }
        }

        public List<Product> GetProducts<Product>() where Product : class
        {  
            {
                return _dbContext.Set<Product>().ToList();
            }
        }
        public List<Customer> GetCustomers<Customer>() where Customer : class
        {  
            {
                return _dbContext.Set<Customer>().ToList();
            }
        }
        public List<SalesPerson> GetSalesPeople<SalesPerson>() where SalesPerson : class
        {  
            {
                return _dbContext.Set<SalesPerson>().ToList();
            }
        }

         public List<Discount> GetDiscounts<Discount>() where Discount : class
        {  
            {
                return _dbContext.Set<Discount>().ToList();
            }
        }
        
        public IActionResult Index()
        {
            ViewBag.Sales = GetSales<Sale>().OrderByDescending(sale => sale.saleId);
            ViewBag.SalesCount = GetSales<Sale>().Count();
            return View();
        }

        public IActionResult New(List<string> errorMessages)
        {
            ViewBag.Products = GetProducts<Product>().OrderBy(product => product.Name);
            ViewBag.Customers = GetCustomers<Customer>().OrderBy(person => person.LastName);
            ViewBag.SalesPeople = GetSalesPeople<SalesPerson>().Where(person => ((person.TerminationDate == DateTime.MinValue || person.TerminationDate >= DateTime.Today) &&  person.StartDate <= DateTime.Today)).OrderBy(person => person.LastName);
            ViewBag.Discounts = GetDiscounts<Discount>();
            ViewBag.ErrorMessages = errorMessages; 

            return View();
        }

        public IActionResult Save(Sale sale)
        {
            sale.SaleDate = DateTime.Today;
            List<string> errorMessages = new List<string>();
            Product soldProductFromDB = _dbContext.Products.ToList().Find(p => p.productId == sale.productId);
            SalesPerson seller = _dbContext.SalesPeople.ToList().Find(p => p.salesPersonId == sale.salesPersonId);

            if(seller != null && seller.TerminationDate != DateTime.MinValue && seller.TerminationDate < sale.SaleDate)
                errorMessages.Add(string.Format("{0} {1} is Not authorized to complete a sale.",seller.FirstName, seller.LastName));

            if(soldProductFromDB != null){
                if(soldProductFromDB.QuantityOnHand == 0){
                    errorMessages.Add(string.Format("{0} is out of stock.",soldProductFromDB.Name));
                }else{
                    sale.ProductDetail = string.Format("{0} ",soldProductFromDB.Name);
                    sale.SalePrice = soldProductFromDB.SalePrice;
                }
            }

            
            SalesPerson salePerson = _dbContext.SalesPeople.ToList().Find(s => s.salesPersonId == sale.salesPersonId);
            Customer saleCustomer = _dbContext.Customers.ToList().Find(c => c.customerId == sale.customerId);
            List<Discount> discountsInHand = _dbContext.Discounts.ToList().FindAll(d => d.productId == sale.productId);
            
            
            if(salePerson != null)
                sale.SalePersonName = string.Format("{1}, {0}",salePerson.FirstName, salePerson.LastName);

            if(saleCustomer != null)
                sale.SaleCustomerName = string.Format("{1}, {0}",saleCustomer.FirstName, saleCustomer.LastName);
            if(discountsInHand != null && discountsInHand.Count > 0){
                double desiredDiscountPercentage = 0;
                foreach (Discount discount in discountsInHand)
                {
                    if(sale.SaleDate >= discount.BeginDate && sale.SaleDate <= discount.EndDate){
                        
                        if(desiredDiscountPercentage < discount.DiscountPercentage){
                            desiredDiscountPercentage = discount.DiscountPercentage;
                        }

                        sale.SalePrice = sale.SalePrice * ((100 - desiredDiscountPercentage) / 100);
                        sale.ProductDetail = string.Format("{0}  %{1} discount included!!!", sale.ProductDetail, desiredDiscountPercentage.ToString());
                    

                    
                    }
                }
            }
            
            

            // double minRequiredSaleAmount = soldProductFromDB.PurchasePrice * 1.2;
            // if(sale.SalePrice  < minRequiredSaleAmount){
            //     errorMessages.Add(string.Format("Sale Price (${0}) after discount(if any) must be greater than minimum allowed Sale amount (${1}).",sale.SalePrice, minRequiredSaleAmount ));
            // }

            // double maxAllowedSaleAmount = soldProductFromDB.SalePrice * 1.4;
            // if(sale.SalePrice  > maxAllowedSaleAmount){
            //     errorMessages.Add(string.Format("Sale Price (${0}) after discount(if any) must be less than maximum allowed Sale amount (${1}).",sale.SalePrice, maxAllowedSaleAmount));
            // }
                
            sale.SaleCommission = (sale.SalePrice - soldProductFromDB.PurchasePrice) * (soldProductFromDB.CommissionPercentage / 100);
            
            if(errorMessages.Count > 0){
                return RedirectToActionPermanent("New", new{errorMessages = errorMessages});
            }else {
                _dbContext.Sales.Add(sale);
                _dbContext.SaveChanges();
                soldProductFromDB.QuantityOnHand  -= 1;
                _dbContext.Attach(soldProductFromDB);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
           
        }
    }
}