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
    public class SalesPersonController : Controller
    {
        private readonly MainDataBaseContext _dbContext;
        private string errorMessage = string.Empty;

        public SalesPersonController(MainDataBaseContext context)
        {
            _dbContext = context;
        }


        public List<SalesPerson> GetSalesPeople<SalesPerson>() where SalesPerson : class
        {  
            {
                return _dbContext.Set<SalesPerson>().ToList();
            }
        }

        public IActionResult Index()
        {
            ViewBag.SalesPeople = GetSalesPeople<SalesPerson>();
            return View();
        }

        public IActionResult New(string msg)
        {
            ViewBag.Message = msg;
            return View();
        }

        public IActionResult Save(SalesPerson person)
        {
            SalesPerson isPersonExist = _dbContext.SalesPeople.ToList().Find(p => (p.FirstName.ToLower() == person.FirstName.ToLower() && p.LastName.ToLower() == person.LastName.ToLower() && p.PhoneNumber == person.PhoneNumber));
           if(isPersonExist == null){
                _dbContext.SalesPeople.Add(person);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                errorMessage =  "The user already exists in Same First/Last Name and Phone Number";
                return RedirectToActionPermanent("New", new{msg = errorMessage});
            }
        }

        public IActionResult UpdateRecord(SalesPerson person)
        {
            _dbContext.Update(person);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int salesPersonId)
        {
            ViewBag.Person = _dbContext.SalesPeople.ToList().Find(p => p.salesPersonId == salesPersonId);
            return View();
        }

        public IActionResult Delete(int salesPersonId){
            
            SalesPerson salesPersonToBeRemoved = _dbContext.SalesPeople.ToList().Find(c => c.salesPersonId == salesPersonId);
            if(salesPersonToBeRemoved != null){
                _dbContext.Remove(salesPersonToBeRemoved);
                _dbContext.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
    }
}