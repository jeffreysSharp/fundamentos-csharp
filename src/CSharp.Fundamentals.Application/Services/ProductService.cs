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

        public void CreateProduct(Product product)
        {
            _productRepository.CreateProduct(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(Guid productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public void UpdateProduct(Guid id, string name, decimal price)
        {
            var existingProduct = _productRepository.GetProductById(id);
            if (existingProduct == null)
                throw new KeyNotFoundException("Produto não encontrado");

            var updatedProduct = existingProduct.Update(name, price);
            _productRepository.UpdateProduct(updatedProduct);
        }

        public void DeleteProduct(Guid productId)
        {
            _productRepository.DeleteProduct(productId);
        }
    }
}
