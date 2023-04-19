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
        
        public IActionResult Index()
        {
            string salesInDetailsQuery = "SELECT sale.\"saleId\" AS salesInDetailsId, sale.\"SaleDate\" AS SalesInDetailsDate " +
                                            ",sale.\"SalePrice\",sale.\"productId\" AS salesInDetailsProductId ,product.\"Name\" ||' by '||product.\"Manufacturer\" AS SalesProductName " +
                                            ",sale.\"customerId\" AS salesInDetailsCustomerId, customer.\"LastName\" ||', '|| customer.\"FirstName\" AS SalesInDetailsCustomerName " +
                                            ",sale.\"salesPersonId\" AS salesPersonId,salesPerson.\"LastName\" ||', '|| salesPerson.\"FirstName\" AS SalesInDetailsSalesPersonName " +
                                            ",(sale.\"SalePrice\" - product.\"PurchasePrice\") * (product.\"CommissionPercentage\" / 100) AS SalePersonCommission " +
                                            "FROM \"Sales\" sale " +
                                            "JOIN \"Products\" product on product.\"productId\" = sale.\"productId\" " +
                                            "JOIN \"Customers\" customer ON customer.\"customerId\" = sale.\"customerId\" " +
                                            "JOIN \"SalesPeople\" salesPerson ON salesPerson.\"salesPersonId\" = sale.\"salesPersonId\" ORDER BY sale.\"SaleDate\" DESC ";

            
            ViewBag.SalesInDetails =  _dbContext.SalesInDetails.FromSqlRaw(salesInDetailsQuery).ToList();
             
            return View();
        }

         public IActionResult New()
        {
            ViewBag.Products = GetProducts<Product>().OrderBy(product => product.Name);
            ViewBag.Customers = GetCustomers<Customer>();
            ViewBag.SalesPeople = GetSalesPeople<SalesPerson>();
            return View();
        }

        public IActionResult Save(Sale sale)
        {
            _dbContext.Sales.Add(sale);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}