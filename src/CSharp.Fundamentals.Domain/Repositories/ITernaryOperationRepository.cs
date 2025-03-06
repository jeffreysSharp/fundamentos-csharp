using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface ITernaryOperationRepository
    {
        void Add(TernaryOperation operation);
        IEnumerable<TernaryOperation> GetAll();
        TernaryOperation? GetById(Guid id);
    }
}
