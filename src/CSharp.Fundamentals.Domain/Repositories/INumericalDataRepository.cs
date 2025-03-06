using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface INumericalDataRepository
    {
        void Add(NumericalData data);
        IEnumerable<NumericalData> GetAll();
        NumericalData? GetById(Guid id);
    }
}