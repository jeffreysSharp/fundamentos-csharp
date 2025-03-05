using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface INumericDataRepository
    {
        void Add(NumericDataExample data);
        IEnumerable<NumericDataExample> GetAll();
        NumericDataExample? GetById(Guid id);
    }
}