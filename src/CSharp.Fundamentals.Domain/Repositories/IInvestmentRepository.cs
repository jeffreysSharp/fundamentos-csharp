using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface IInvestmentRepository
    {
        void AddInvestment(Investment investment);
        IEnumerable<Investment> GetAllInvestments();
        Investment GetInvestmentById(Guid id);
    }
}