namespace CSharp.Fundamentals.Application.DTOs
{
    public class LogicalOperationDto
    {
        public Guid Id { get; set; }
        public bool FirstCondition { get; set; }
        public bool SecondCondition { get; set; }
        public bool AndResult { get; set; }
        public bool OrResult { get; set; }
        public bool NotFirst { get; set; }
        public bool NotSecond { get; set; }
    }
}
