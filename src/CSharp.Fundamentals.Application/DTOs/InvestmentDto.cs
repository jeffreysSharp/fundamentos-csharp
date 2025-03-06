using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.DTOs
{
    public class InvestmentDto
    {
        public Guid Id { get; private set; }
        public string InvestorName { get; private set; }
        public InvestmentType Type { get; private set; }
        public decimal Amount { get; private set; }
        public double InterestRate { get; private set; } // Anual
        public int DurationInMonths { get; private set; }
        public DateTime StartDate { get; private set; }
    }
}
