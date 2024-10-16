﻿namespace SANA.Shop.Domain.Entities.Cart
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
