namespace CSharp.Fundamentals.Application.DTOs
{
    public class RelationalOperationDto
    {
        public Guid Id { get; set; }
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public bool IsEqual { get; set; }
        public bool IsNotEqual { get; set; }
        public bool IsGreaterThan { get; set; }
        public bool IsLessThan { get; set; }
        public bool IsGreaterOrEqual { get; set; }
        public bool IsLessOrEqual { get; set; }
    }
}
