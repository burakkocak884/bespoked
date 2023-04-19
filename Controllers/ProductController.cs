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
    public class ProductController : Controller
    {
        private readonly MainDataBaseContext _dbContext;
        public string errorMessage = string.Empty;

        public ProductController(MainDataBaseContext context)
        {
            _dbContext = context;
        }


        public List<Product> GetProducts<Product>() where Product : class
        {  
            {
                return _dbContext.Set<Product>().ToList();
            }
        }

        public IActionResult Index(int userId)
        {
            ViewBag.Products = GetProducts<Product>().OrderBy(product => product.Name);
            return View();
        }

        public IActionResult New(string msg)
        {
            ViewBag.Message = msg;
            return View();
        }

        public IActionResult Save(Product product)
        {
            Product dublicateProduct = _dbContext.Products.ToList().Find(p => (p.Name.ToLower() == product.Name.ToLower() && p.Manufacturer.ToLower() == product.Manufacturer.ToLower() && p.Style.ToLower() == product.Style.ToLower()));
      
            if(dublicateProduct == null){
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                errorMessage =  "The product already exists in Same Name, Manufacturer, and Style";
                return RedirectToActionPermanent("New", new{msg = errorMessage});
            }
 
        }

        public IActionResult Update(int productId)
        {
            ViewBag.Product = _dbContext.Products.ToList().Find(p => p.productId == productId);
            return View();
        }

        public IActionResult UpdateRecord(Product product)
        {
            _dbContext.Update(product);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}