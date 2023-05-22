using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using profisee_project.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace profisee_project.Controllers
{
    public class DiscountController : Controller
    {

        private readonly MainDataBaseContext _dbContext;

        public DiscountController(MainDataBaseContext context)
        {
            _dbContext = context;
        }


        public List<Discount> GetDiscounts<Discount>() where Discount : class
        {  
            {
                return _dbContext.Set<Discount>().ToList();
            }
        }

         public List<Product> GetProducts<Product>() where Product : class
        {  
            {
                return _dbContext.Set<Product>().ToList();
            }
        }

        public IActionResult Index(){
            
            ViewBag.Discounts = GetProducts<Discount>().OrderByDescending(d => d.EndDate);
            return View();
        }

        public IActionResult New(List<string> msgs){
            
            ViewBag.Products = GetProducts<Product>().OrderBy(p => p.Name);
            ViewBag.Messages = msgs;
            return View();
        }

         public IActionResult Save(Discount discount){
            
            List<string> errorMessages = new List<string>();

            Discount exactDiscount = GetDiscounts<Discount>().Find(d => (d.BeginDate == discount.BeginDate && d.EndDate == discount.EndDate && d.productId == discount.productId));
            List<Discount> sameProductDiscounts = GetDiscounts<Discount>().FindAll(d => d.productId == discount.productId);
            Product matchingProduct = GetProducts<Product>().Find(p => p.productId == discount.productId);

            if(discount.BeginDate.Date > discount.EndDate.Date){
                errorMessages.Add("Begin Date can not be a later date than End Date");
            }
            
            if(exactDiscount != null){
               errorMessages.Add("The same discount already exists.");
            }

            if(discount.BeginDate.Date < DateTime.Now.Date){
                errorMessages.Add("Discount Start date can not be a Date in the past.");
            }

            if(discount.DiscountPercentage <= 0){
                errorMessages.Add("Percentage Value needs to be greater than 0.");
            }

            if(discount.DiscountPercentage > 35){
                errorMessages.Add("Maximum allowed discount rate is 35.");
            }


            if(sameProductDiscounts != null && sameProductDiscounts.Count > 0){
                foreach (Discount d in sameProductDiscounts)
                {
                    if(discount.BeginDate <= d.EndDate){
                    errorMessages.Add(string.Format("Same product currently has a %{1} discount that will end on: {0}",d.EndDate.ToString("MMM dd yyyy"),d.DiscountPercentage.ToString()));
                    }
                    
                    if(discount.EndDate.Date >= d.BeginDate.Date && discount.EndDate.Date <= d.EndDate.Date){
                        errorMessages.Add(string.Format("Same product currently has a %{1} discount that will begin on: {0}",d.BeginDate.ToString("MMM dd yyyy"),d.DiscountPercentage.ToString()));
                    }
                }
                
            }
            
            

            if(errorMessages.Count > 0 ){
                
                return RedirectToActionPermanent("New", new{msgs = errorMessages});
            
            }else{
                
                if(matchingProduct != null)
                    discount.ProductDescription = string.Format("{0} by {1}",matchingProduct.Name, matchingProduct.Manufacturer);
                
                _dbContext.Discounts.Add(discount);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
        
        }
    }
}