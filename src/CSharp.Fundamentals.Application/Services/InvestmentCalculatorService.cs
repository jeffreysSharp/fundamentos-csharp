using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.Services
{
    

    public class InvestmentCalculatorService
    {
        public decimal CalculateEarnings(Investment investment)
        {
            double monthlyRate = investment.InterestRate / 12 / 100;
            double compoundFactor = Math.Pow(1 + monthlyRate, investment.DurationInMonths);

            decimal finalAmount = investment.Amount * (decimal)compoundFactor;
            decimal earnings = finalAmount - investment.Amount;

            return earnings;
        }
    }
}