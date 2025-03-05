namespace CSharp.Fundamentals.Domain.Entities
{
    public class RelationalOperation
    {
        public Guid Id { get; private set; }
        public double FirstValue { get; private set; }
        public double SecondValue { get; private set; }
        public bool IsEqual { get; private set; }
        public bool IsNotEqual { get; private set; }
        public bool IsGreaterThan { get; private set; }
        public bool IsLessThan { get; private set; }
        public bool IsGreaterOrEqual { get; private set; }
        public bool IsLessOrEqual { get; private set; }

        public RelationalOperation(double firstValue, double secondValue)
        {
            Id = Guid.NewGuid();
            FirstValue = firstValue;
            SecondValue = secondValue;
            IsEqual = firstValue == secondValue;
            IsNotEqual = firstValue != secondValue;
            IsGreaterThan = firstValue > secondValue;
            IsLessThan = firstValue < secondValue;
            IsGreaterOrEqual = firstValue >= secondValue;
            IsLessOrEqual = firstValue <= secondValue;
        }
    }
}