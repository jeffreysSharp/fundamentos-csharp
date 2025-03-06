using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IRelationalOperationRepository
    {
        void Add(RelationalOperation operation);
        IEnumerable<RelationalOperation> GetAll();
        RelationalOperation? GetById(Guid id);
    }
}