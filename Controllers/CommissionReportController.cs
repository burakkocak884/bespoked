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
    public class CommissionReportController : Controller
    {
        private readonly MainDataBaseContext _dbContext;

        public CommissionReportController(MainDataBaseContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}