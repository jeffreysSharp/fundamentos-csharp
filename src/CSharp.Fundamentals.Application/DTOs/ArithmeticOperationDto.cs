namespace CSharp.Fundamentals.Application.DTOs
{
    public class ArithmeticOperationDto
    {
        public Guid Id { get; set; }
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Sum { get; set; }
        public double Subtraction { get; set; }
        public double Multiplication { get; set; }
        public double Division { get; set; }
        public double Modulo { get; set; }
        public double IncrementFirst { get; set; }
        public double IncrementSecond { get; set; }
        public double DecrementFirst { get; set; }
        public double DecrementSecond { get; set; }
    }
}
