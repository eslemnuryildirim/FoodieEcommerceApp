using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodieEcommerceApp.Domain.Entities;

namespace FoodieEcommerceApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
    }
}

