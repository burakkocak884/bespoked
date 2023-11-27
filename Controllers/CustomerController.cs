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

        public IActionResult New(string msg){
            ViewBag.Message = msg;
            return View();
        }

        public IActionResult Save(Customer customer){

            string errorMessage = string.Empty;
            customer.StartDate = DateTime.Today;
            Customer duplicateCustomer = _dbContext.Customers.ToList().Find(c => c.PhoneNumber == customer.PhoneNumber);
            if(duplicateCustomer == null){
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                errorMessage =  string.Format("{0} {1} with  Phone Number: {2} already exists in System. Please update the Phone Number",duplicateCustomer.FirstName, duplicateCustomer.LastName, duplicateCustomer.PhoneNumber);
                return RedirectToActionPermanent("New", new{msg = errorMessage});            }
            
            
            
        }

        public IActionResult Update(int customerId){
        
            ViewBag.Customer = _dbContext.Customers.ToList().Find(c => c.customerId == customerId);
            return View();
        }
        public IActionResult UpdateRecord(Customer customer){
            _dbContext.Update(customer);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int customerId){
            
            Customer customertToBeRemoved = _dbContext.Customers.ToList().Find(c => c.customerId == customerId);
            if(customertToBeRemoved != null){
                _dbContext.Remove(customertToBeRemoved);
                _dbContext.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        
    }
}