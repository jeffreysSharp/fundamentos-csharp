using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IInvestmentRepository
    {
        void Add(Investment investment);
        IEnumerable<Investment> GetAll();
        Investment GetById(Guid id);
    }
}