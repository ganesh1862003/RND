using DI.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using CoreAppMVC.Services.Interface;
namespace CoreAppMVC.Services.Manager
{
    public class ProductService : IProductService
    {
        public ILogger<ProductService> Logger { get; set; }
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            Logger = NullLogger<ProductService>.Instance;
        }

        public void Delete(int ? id)
        {
            _productRepository.Delete(id);
            Logger.LogInformation($"Deleted a product with id = {id}");
        }
    }
}
