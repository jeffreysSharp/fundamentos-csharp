using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonRelationalOperationRepository : JsonRepository<RelationalOperation>, IRelationalOperationRepository
    {
        public JsonRelationalOperationRepository() : base("relational-operation") { }

        public RelationalOperation? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}