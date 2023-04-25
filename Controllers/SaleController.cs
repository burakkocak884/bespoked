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

        public IActionResult New(string msg)
        {
            ViewBag.Products = GetProducts<Product>().OrderBy(product => product.Name);
            ViewBag.Customers = GetCustomers<Customer>();
            ViewBag.SalesPeople = GetSalesPeople<SalesPerson>();
            ViewBag.Discounts = GetDiscounts<Discount>();
            ViewBag.ErrorMessage = msg; 

            return View();
        }

        public IActionResult Save(Sale sale)
        {
            Product soldProductFromDB = _dbContext.Products.ToList().Find(p => p.productId == sale.productId);
            string errorMessage = string.Empty;
            if(soldProductFromDB.QuantityOnHand > 0){
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
            else
            {
                errorMessage = string.Format("Quantity of {0} is currently Zero. Sale is Unsucessful.",soldProductFromDB.Name);
                return RedirectToActionPermanent("New", new{msg = errorMessage});
            }
           
        }
        
    }
}