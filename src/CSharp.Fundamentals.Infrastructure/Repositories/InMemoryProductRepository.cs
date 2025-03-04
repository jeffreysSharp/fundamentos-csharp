using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly Dictionary<Guid, Product> _products = new();
        public void Add(Product product) => _products[product.Id] = product;
        public Product GetById(Guid id) => _products.ContainsKey(id) ? _products[id] : null;
        public IEnumerable<Product> GetAll() => _products.Values;
    }
}
