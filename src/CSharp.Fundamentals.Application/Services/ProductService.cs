using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CreateProduct(string name, decimal price)
        {
            var product = new Product(name, price);

            _productRepository.CreateProduct(product);

            return product;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(Guid productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public void UpdateProduct(Guid productId, string name, decimal price)
        {
            var product = _productRepository.GetProductById(productId);

            if(product != null)
            {
                _productRepository.UpdateProduct(product);
            }
        }

        public void DeleteProduct(Guid productId)
        {
            _productRepository.DeleteProduct(productId);
        }

    }
}
