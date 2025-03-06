using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonFunctionRepository : JsonRepository<Function>, IFunctionRepository
    {
        public JsonFunctionRepository() : base("function.json") { }

        public Function? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}
