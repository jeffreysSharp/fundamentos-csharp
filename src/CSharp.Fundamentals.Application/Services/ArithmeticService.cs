namespace CSharp.Fundamentals.Application.Services
{
    public class ArithmeticService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(double a, double b) => b == 0 ? throw new DivideByZeroException("Cannot divide by zero") : a / b;
        public int Modulus(int a, int b) => a % b;

        public int Increment(ref int value) => ++value;
        public int Decrement(ref int value) => --value;
    }
}
