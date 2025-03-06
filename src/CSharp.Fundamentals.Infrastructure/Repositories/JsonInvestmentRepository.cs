using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonInvestmentRepository : JsonRepository<Investment>, IInvestmentRepository
    {
        public JsonInvestmentRepository() : base("investment") { }

        public Investment? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}
