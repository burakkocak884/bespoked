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
    public class CommissionReportController : Controller
    {
        private readonly MainDataBaseContext _dbContext;

        public CommissionReportController(MainDataBaseContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index(int selectedQuarter, string year)
        {
            DateTime currentTime = DateTime.Now;
            string beginningOfQuarter = string.Empty;
            string endingOfQuarter = string.Empty;
            string quarterDescription = string.Empty;
            string reportYear = string.IsNullOrEmpty(year)? currentTime.Year.ToString() : year;

            int quarter = (selectedQuarter > 0) ? selectedQuarter : ((Convert.ToInt32(currentTime.AddMonths(-3).Month) + 2)/3)+1;
            
            
            switch(quarter){
                
                case 1:
                    beginningOfQuarter = "01-01";
                    endingOfQuarter = "03-31";
                    quarterDescription = string.Format("First Quarter of {0}.", reportYear);
                    break;
                
                case 2:
                    beginningOfQuarter = "04-01";
                    endingOfQuarter = "06-30";
                    quarterDescription = string.Format("Second Quarter of {0}.", reportYear);
                    break;
                
                case 3:
                    beginningOfQuarter = "07-01";
                    endingOfQuarter = "09-30";
                    quarterDescription = string.Format("Third Quarter of {0}.", reportYear);
                    break;
                
                case 4:
                    beginningOfQuarter = "10-01";
                    endingOfQuarter = "12-31";
                    quarterDescription = string.Format("Fourth Quarter of {0}.", reportYear);
                    break;
            
            }
            
            List<string> yearRange = new List<string>(); 
            for(int i = 0; i < 11; i++){
                yearRange.Add(currentTime.AddYears(-i).Year.ToString());
            }


            string generateStatement = "SELECT "+
                                            "staff.\"LastName\" ||', ' || staff.\"FirstName\" AS salespersonname " +
                                            ",SUM(\"SaleCommission\") AS quarterlycommission " +
                                            ",staff.\"PhoneNumber\" AS SalesPersonPhoneNumber" +
                                            ",'{0}' AS quarterDescription " +
                                            ",Count(sale.\"saleId\") AS NumberOfSales " +
                                            ",staff.\"salesPersonId\" AS comissionReportId " +
                                        "FROM \"Sales\" sale " +
                                        "JOIN \"SalesPeople\" staff on staff.\"salesPersonId\" = sale.\"salesPersonId\" " +
                                        "Where sale.\"SaleDate\" BETWEEN '{1}-{2}' AND '{1}-{3}' " +
                                        "GROUP BY staff.\"salesPersonId\", staff.\"FirstName\" " +
                                        "ORDER BY SUM(\"SaleCommission\") DESC "; 
            
            generateStatement = string.Format(generateStatement, quarterDescription, reportYear, beginningOfQuarter, endingOfQuarter);
            
            ViewBag.CommissionReportList =  _dbContext.CommisionReports.FromSqlRaw(generateStatement).ToList();
            ViewBag.PrePopulatedYearRange = yearRange;
            ViewBag.PreviouslySelectedYear = reportYear;
            ViewBag.PreviouslySelectedQuarter = quarterDescription.Split(" ")[0];;
            return View();
        }
    }
}