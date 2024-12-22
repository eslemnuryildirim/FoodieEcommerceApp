namespace FoodieEcommerce.Application.Services


    public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task CreateOrderAsync(Order order)
    {
        // iş mantıgı : ürün stok kontrolü vs.
        await _orderRepository.CreateOrderAsync(order);
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        return await _orderRepository.GetAllOrdersAsync();
    }
}