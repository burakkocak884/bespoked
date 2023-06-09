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
            string salesInDetailsQuery = "SELECT sale.\"saleId\" AS salesInDetailsId, TO_CHAR(sale.\"SaleDate\" :: DATE, 'Mon dd, yyyy') AS SalesInDetailsDate " +
                                                ",sale.\"SalePrice\",sale.\"productId\" AS salesInDetailsProductId ,product.\"Name\" AS SalesProductName " +
                                                ",sale.\"customerId\" AS salesInDetailsCustomerId, customer.\"LastName\" ||', '|| customer.\"FirstName\" AS SalesInDetailsCustomerName " +
                                                ",sale.\"salesPersonId\" AS salesPersonId,salesPerson.\"LastName\" ||', '|| salesPerson.\"FirstName\" AS SalesInDetailsSalesPersonName " +
                                                ",sale.\"SaleCommission\" AS SalePersonCommission " +
                                            "FROM \"Sales\" sale " +
                                            "JOIN \"Products\" product on product.\"productId\" = sale.\"productId\" " +
                                            "JOIN \"Customers\" customer ON customer.\"customerId\" = sale.\"customerId\" " +
                                            "JOIN \"SalesPeople\" salesPerson ON salesPerson.\"salesPersonId\" = sale.\"salesPersonId\" " +
                                            "ORDER BY sale.\"SaleDate\" DESC , salesPerson.\"LastName\" ASC";

            
            ViewBag.SalesInDetails =  _dbContext.SalesInDetails.FromSqlRaw(salesInDetailsQuery).ToList();
            return View();
        }

        public IActionResult New(List<string> errorMessages)
        {
            ViewBag.Products = GetProducts<Product>().OrderBy(product => product.Name);
            ViewBag.Customers = GetCustomers<Customer>().OrderBy(person => person.LastName);
            ViewBag.SalesPeople = GetSalesPeople<SalesPerson>().OrderBy(person => person.LastName);
            ViewBag.Discounts = GetDiscounts<Discount>();
            ViewBag.ErrorMessages = errorMessages; 

            return View();
        }

        public IActionResult Save(Sale sale)
        {
            List<string> errorMessages = new List<string>();
            Product soldProductFromDB = _dbContext.Products.ToList().Find(p => p.productId == sale.productId);
            SalesPerson seller = _dbContext.SalesPeople.ToList().Find(p => p.salesPersonId == sale.salesPersonId);

            if(seller != null && seller.TerminationDate < sale.SaleDate)
                errorMessages.Add(string.Format("{0} {1} is Not authorized to complete a sale.",seller.FirstName, seller.LastName));


            if(soldProductFromDB.QuantityOnHand == 0){
                errorMessages.Add(string.Format("{0} is out of stock.",soldProductFromDB.Name));
            }
           

            if(errorMessages.Count > 0){
                return RedirectToActionPermanent("New", new{errorMessages = errorMessages});
            }else{
                Discount currentDiscount = _dbContext.Discounts.ToList().Find(d => d.productId == sale.productId);
                if(currentDiscount != null){
                    sale.SalePrice = sale.SalePrice * ((100 - currentDiscount.DiscountPercentage) / 100);
                }
                sale.SaleCommission = (sale.SalePrice - soldProductFromDB.PurchasePrice) * (soldProductFromDB.CommissionPercentage / 100);
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