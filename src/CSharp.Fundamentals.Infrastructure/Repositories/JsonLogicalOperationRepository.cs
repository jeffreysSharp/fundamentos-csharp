using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonLogicalOperationRepository : JsonRepository<LogicalOperation>, ILogicalOperationRepository
    {
        public JsonLogicalOperationRepository() : base("logical-operation") { }

        public LogicalOperation? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}