using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using profisee_project.Models;

namespace profisee_project.Controllers
{
    public class CustomerController : Controller
    {
         private readonly MainDataBaseContext _dbContext;

        public CustomerController(MainDataBaseContext context)
        {
            _dbContext = context;
        }


        public List<Customer> GetCustomers<Customer>() where Customer : class
        {  
            {
                return _dbContext.Set<Customer>().ToList();
            }
        }

        public IActionResult Index(int userId)
        {
            ViewBag.Customers = GetCustomers<Customer>().OrderBy(customer => customer.LastName);
            return View();
        }
    }
}