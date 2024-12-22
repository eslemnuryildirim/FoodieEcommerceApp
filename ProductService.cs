namespace FoodieEcommerce.Application.Services


    public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task AddProductAsync(Product product)
    {
        // iş mantıgı : ürün stok kontrolü vs.
        await _productRepository.AddProductAsync(product);
    }

    public async Task<IEnumerable<Product>> GetAllProductAsync()
    {
        return await _productRepository.GetAllProductAsync();
    }
}
