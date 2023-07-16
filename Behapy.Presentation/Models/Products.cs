﻿namespace Behapy.Presentation.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int PromotionId { get; set; }
        public int CategoryId { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}