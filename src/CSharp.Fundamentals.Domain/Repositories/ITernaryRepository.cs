using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface ITernaryRepository
    {
        void Add(TernaryOperation operation);
        IEnumerable<TernaryOperation> GetAll();
        TernaryOperation? GetById(Guid id);
    }
}
