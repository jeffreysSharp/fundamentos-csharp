namespace CSharp.Fundamentals.Domain.Entities
{
    public class ArithmeticOperation
    {
        public Guid Id { get; private set; }
        public double FirstNumber { get; private set; }
        public double SecondNumber { get; private set; }
        public double Sum { get; private set; }
        public double Subtraction { get; private set; }
        public double Multiplication { get; private set; }
        public double Division { get; private set; }
        public double Modulo { get; private set; }
        public double IncrementFirst { get; private set; }
        public double IncrementSecond { get; private set; }
        public double DecrementFirst { get; private set; }
        public double DecrementSecond { get; private set; }

        public ArithmeticOperation(double firstNumber, double secondNumber)
        {
            Id = Guid.NewGuid();
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Sum = firstNumber + secondNumber;
            Subtraction = firstNumber - secondNumber;
            Multiplication = firstNumber * secondNumber;
            Division = secondNumber != 0 ? firstNumber / secondNumber : double.NaN;
            Modulo = secondNumber != 0 ? firstNumber % secondNumber : double.NaN;
            IncrementFirst = firstNumber + 1;
            IncrementSecond = secondNumber + 1;
            DecrementFirst = firstNumber - 1;
            DecrementSecond = secondNumber - 1;
        }
    }
}
