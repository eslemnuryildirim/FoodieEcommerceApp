using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodieEcommerceApp.Domain.Entities;

namespace FoodieEcommerceApp.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}
