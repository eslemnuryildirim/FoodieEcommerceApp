using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodieEcommerceApp.Domain.Entities;
using FoodieEcommerceApp.Domain.Interfaces;
using FoodieEcommerceApp.Infrastructure.Context;

namespace FoodieEcommerceApp.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FoodieEcommerceDbContext _context;

        public OrderRepository(FoodieEcommerceDbContext context)
        {
            _context = context;
        }

        public async Task CreateOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
