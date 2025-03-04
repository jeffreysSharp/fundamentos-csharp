using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(Guid id);
    }
}
