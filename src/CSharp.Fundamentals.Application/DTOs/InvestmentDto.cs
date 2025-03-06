using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.DTOs
{
    public class InvestmentDto
    {
        public Guid Id { get; set; }
        public string InvestorName { get; set; }
        public InvestmentType Type { get; set; }
        public decimal Amount { get; set; }
        public double InterestRate { get; set; }
        public int DurationInMonths { get; set; }
        public DateTime StartDate { get; set; }
    }
}
