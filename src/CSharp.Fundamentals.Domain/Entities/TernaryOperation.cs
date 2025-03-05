namespace CSharp.Fundamentals.Domain.Entities
{
    public class TernaryOperation
    {
        public Guid Id { get; private set; }
        public int Value { get; private set; }
        public string Result { get; private set; }

        public TernaryOperation(int value)
        {
            Id = Guid.NewGuid();
            Value = value;
            Result = (value >= 0) ? "Positivo" : "Negativo";
        }
    }
}
