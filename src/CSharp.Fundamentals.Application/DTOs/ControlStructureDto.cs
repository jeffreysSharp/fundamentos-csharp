namespace CSharp.Fundamentals.Application.DTOs
{
    public class ControlStructureDto
    {
        public Guid Id { get; set; }
        public int InputValue { get; set; }
        public string IfElseResult { get; set; } = string.Empty;
        public string SwitchResult { get; set; } = string.Empty;
        public List<string> LoopResults { get; set; } = new();
    }
}