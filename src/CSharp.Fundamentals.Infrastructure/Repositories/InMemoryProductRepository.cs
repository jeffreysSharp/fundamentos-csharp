using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly Dictionary<Guid, Product> _products = new();

        public void CreateProduct(Product product) => _products[product.Id] = product;
        public IEnumerable<Product> GetAllProducts() => _products.Values;
        public Product GetProductById(Guid productId) => _products.ContainsKey(productId) ? _products[productId] : null;
        public void UpdateProduct(Product product)
        {
            if (_products.ContainsKey(product.Id))
            {
                _products[product.Id] = product;
            }
        }

        public void DeleteProduct(Guid productId)
        {
            if (_products.ContainsKey(productId))
                _products.Remove(productId);
        }

    }
}
