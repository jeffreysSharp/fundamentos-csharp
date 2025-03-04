namespace CSharp.Fundamentals.Application.Services
{
    using CSharp.Fundamentals.Domain.Entities;
    using CSharp.Fundamentals.Domain.Repositories;

    public class InvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }

        public Investment RegisterInvestment(string investorName, InvestmentType type, decimal amount, double interestRate, int durationInMonths)
        {
            var investment = new Investment(investorName, type, amount, interestRate, durationInMonths);
            _investmentRepository.AddInvestment(investment);
            return investment;
        }

        public IEnumerable<Investment> GetAllInvestments() => _investmentRepository.GetAllInvestments();

        public Investment GetInvestmentById(Guid id) => _investmentRepository.GetInvestmentById(id);
    }
}