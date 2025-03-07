namespace CSharp.Fundamentals.Domain.Entities
{
    public class Investor
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public InvestmentType Type { get; private set; }
        public decimal Amount { get; private set; }
        public double InterestRate { get; private set; }
        public int DurationInMonths { get; private set; }
        public DateTime StartDate { get; private set; }

        public Investor(string name, InvestmentType type, decimal amount, double interestRate, int durationInMonths)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            Amount = amount;
            InterestRate = interestRate;
            DurationInMonths = durationInMonths;
            StartDate = DateTime.UtcNow;
        }
    }
}