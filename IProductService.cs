namespace FoodieEcommerce.Application.Interfaces

    public interface IProductService
{
    Task CreateOrderAsync(Product product);

    Task<IEnumerable<Product>> GetAllOrderAsync();

}