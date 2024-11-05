﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShop.Models
{
    public class Product
    {
        public Product()
        {
            ProductParts = new List<ProductParts>();
        }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";

        [ValidateNever]
        public Category? Category { get; set; } //A product belongs to category

        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; } //A product can be in many order items

        [ValidateNever]
        public ICollection<ProductParts>? ProductParts { get; set; } //A product can have many parts
    }
}