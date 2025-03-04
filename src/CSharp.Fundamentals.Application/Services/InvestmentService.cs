using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{


    public class InvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;
        private readonly InvestmentCalculatorService _calculatorService;

        public InvestmentService(IInvestmentRepository investmentRepository, InvestmentCalculatorService calculatorService)
        {
            _investmentRepository = investmentRepository;
            _calculatorService = calculatorService;
        }

        public Investment RegisterInvestment(string investorName, InvestmentType type, decimal amount, double interestRate, int durationInMonths)
        {
            var investment = new Investment(investorName, type, amount, interestRate, durationInMonths);
            decimal earnings = _calculatorService.CalculateEarnings(investment);

            Console.WriteLine($"Lucros esperados para {investment.InvestorName}: {earnings:C}");

            _investmentRepository.AddInvestment(investment);
            return investment;
        }

        public IEnumerable<Investment> GetAllInvestments() => _investmentRepository.GetAllInvestments();

        public Investment GetInvestmentById(Guid id) => _investmentRepository.GetInvestmentById(id);

        public decimal GetInvestmentEarnings(Guid id)
        {
            var investment = _investmentRepository.GetInvestmentById(id);
            if (investment == null) return 0;

            return _calculatorService.CalculateEarnings(investment);
        }
    }
}