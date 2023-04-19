using System;

namespace profisee_project.Models
{
    public class SalesInDetails
    {
        public int salesInDetailsId {get;set;}
        public DateTime salesInDetailsDate {get;set;}
        public int salesPersonId {get;set;}
        public string salesInDetailsSalesPersonName {get;set;}
        public int salesInDetailsCustomerId {get;set;}
        public string salesInDetailsCustomerName {get;set;}
        public int salesInDetailsProductId {get;set;}
        public string salesProductName {get;set;}
        public double salePersonCommission {get;set;}
        public double salePrice {get;set;}
    }
}