namespace CarShop.Models
{
    public class ProductParts
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}