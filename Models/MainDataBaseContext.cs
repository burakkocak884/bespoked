
using Microsoft.EntityFrameworkCore;


namespace profisee_project.Models
{
    public class MainDataBaseContext: DbContext
    {
        public MainDataBaseContext(DbContextOptions<MainDataBaseContext> options) : base(options) {} 

        public DbSet<Product> Products {get; set;}
        public DbSet<SalesPerson> SalesPeople {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Sale> Sales {get; set;}
        public DbSet<Discount> Discounts {get; set;}

        public DbSet<SalesInDetails> SalesInDetails {get;set;}
        public DbSet<ComissionReport> CommisionReports {get; set;}

    }
}