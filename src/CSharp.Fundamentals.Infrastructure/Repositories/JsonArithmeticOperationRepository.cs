using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonArithmeticOperationRepository : JsonRepository<ArithmeticOperation>, IArithmeticRepository
    {
        public JsonArithmeticOperationRepository() : base("arithmetic_operation") { }

        public ArithmeticOperation? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}