namespace CSharp.Fundamentals.Domain.Entities
{
    public class Investment
    {
        public Guid Id { get; private set; }
        public string InvestorName { get; private set; }
        public InvestmentType Type { get; private set; }
        public decimal Amount { get; private set; }
        public double InterestRate { get; private set; }
        public int DurationInMonths { get; private set; }
        public DateTime StartDate { get; private set; }

        public Investment(string investorName, InvestmentType type, decimal amount, double interestRate, int durationInMonths)
        {
            Id = Guid.NewGuid();
            InvestorName = investorName;
            Type = type;
            Amount = amount;
            InterestRate = interestRate;
            DurationInMonths = durationInMonths;
            StartDate = DateTime.UtcNow;
        }
    }

    public enum InvestmentType
    {
        CDB,
        LCI,
        LCA
    }
}