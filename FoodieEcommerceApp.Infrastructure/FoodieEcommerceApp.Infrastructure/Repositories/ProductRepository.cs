using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodieEcommerceApp.Domain.Entities;
using FoodieEcommerceApp.Domain.Interfaces;
using FoodieEcommerceApp.Infrastructure.Context;

namespace FoodieEcommerceApp.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FoodieEcommerceDbContext _context;

        public ProductRepository(FoodieEcommerceDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            if (id == Guid.Empty || _context.Products == null)
            {
                return new Product();
            }
            return await _context.Products.FindAsync(id);
        }
    }
}
