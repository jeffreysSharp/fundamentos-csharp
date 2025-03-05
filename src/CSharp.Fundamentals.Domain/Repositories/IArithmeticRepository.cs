using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IArithmeticRepository
    {
        void Add(ArithmeticOperation operation);
        IEnumerable<ArithmeticOperation> GetAll();
        ArithmeticOperation? GetById(Guid id);
    }
}