using System;

namespace profisee_project.Models
{
    public class Discount
    {
        public int discountID{get;set;}
        public DateTime BeginDate {get;set;}
        public DateTime EndDate {get;set;}
        public double DiscountPercentage {get; set;}
        public int productId {get;set;}
    }
}