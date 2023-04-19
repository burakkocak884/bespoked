using System;

namespace profisee_project.Models
{
    public class Sale
    {
        public int saleId {get;set;}
        public DateTime SaleDate {get;set;}
        public double SalePrice {get;set;}
        public int salesPersonId {get;set;}
        public int customerId {get;set;}
        public int productId {get;set;}
    }
}