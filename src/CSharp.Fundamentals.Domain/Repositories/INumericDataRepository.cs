using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface INumericDataRepository
    {
        void Add(NumericData data);
        IEnumerable<NumericData> GetAll();
        NumericData? GetById(Guid id);
    }
}