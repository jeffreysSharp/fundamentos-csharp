namespace CSharp.Fundamentals.Domain.Entities
{
    public class Function
    {
        public Guid Id { get; private set; }
        public int Value { get; private set; }
        public string Status { get; private set; }

        public Function(int value)
        {
            Id = Guid.NewGuid();
            Value = value;
            Status = (value >= 0) ? "Positive" : "Negative"; // Ternary operator
        }
    }
}
