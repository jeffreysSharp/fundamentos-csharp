using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.DTOs
{
    public class InvestorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public InvestmentType Type { get; set; }
        public decimal Amount { get; set; }
        public double InterestRate { get; set; }
        public int DurationInMonths { get; set; }
        public DateTime StartDate { get; set; }
    }
}