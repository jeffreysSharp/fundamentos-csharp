using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonTernaryOperationRepository : JsonRepository<TernaryOperation>, ITernaryOperationRepository
    {
        public JsonTernaryOperationRepository() : base("ternary-operation") { }

        public TernaryOperation? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}