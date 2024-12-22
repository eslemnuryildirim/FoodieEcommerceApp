namespace FoodieEcommerce.Application.Interfaces


public interface IOrderService
{
    Task CreateOrderAsync(Order order);

    Task<IEnumerable<Order>> GetAllOrderAsync();

}