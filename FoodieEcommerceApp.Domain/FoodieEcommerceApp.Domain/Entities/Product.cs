using System;
using FoodieEcommerceApp.Domain.Entities;

namespace FoodieEcommerceApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
