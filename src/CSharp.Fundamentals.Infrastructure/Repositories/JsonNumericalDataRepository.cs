using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonNumericalDataRepository : JsonRepository<NumericalData>, INumericalDataRepository
    {
        public JsonNumericalDataRepository() : base("numerical-data") { }

        public NumericalData? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}