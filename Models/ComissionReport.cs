using System;

namespace profisee_project.Models
{
    public class ComissionReport
    {
        public int comissionReportId {get; set;}
        public string salespersonname {get;set;}
        public string SalesPersonPhoneNumber {get;set;}
        public double quarterlycommission {get;set;}
        public string quarterDescription {get;set;}
        public int NumberOfSales {get;set;}
        public double SaleSum {get;set;}
    }
}