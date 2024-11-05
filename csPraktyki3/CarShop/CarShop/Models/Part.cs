using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarShop.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }

        [ValidateNever]
        public ICollection<ProductParts> ProductParts { get; set; }
    }
}