using System;

namespace profisee_project.Models
{
    public class SalesInDetails
    {
        public int salesInDetailsId {get;set;}
        public string salesInDetailsDate {get;set;}
        public int salesPersonId {get;set;}
        public string SalePersonName {get;set;}
        public int salesInDetailsCustomerId {get;set;}
        public string SaleCustomerName {get;set;}
        public int salesInDetailsProductId {get;set;}
        public string salesProductName {get;set;}
        public double salePersonCommission {get;set;}
        
        public double salePrice {get;set;}
    }
}