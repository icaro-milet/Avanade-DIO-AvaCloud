namespace DIO.AvaCloud.Domain
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Seller { get; set; }

        public override bool Validate()
        {
           return !string.IsNullOrEmpty(ProductName);
        }
    }
}
