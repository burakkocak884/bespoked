namespace profisee_project.Models
{
    public class Product
    {
        public int productId {get; set;}
        public string Name {get; set;}
        public string Manufacturer {get; set;}
        public string Style {get; set;}
        public double PurchasePrice {get; set;}
        public double SalePrice {get; set;}
        public int QuantityOnHand {get; set;}
        public double CommissionPercentage {get; set;}

    }
}