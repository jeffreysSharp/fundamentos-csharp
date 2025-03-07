namespace CSharp.Fundamentals.Domain.Entities
{
    public class ControlStructure
    {
        public Guid Id { get; set; }
        public int InputValue { get; set; }
        public string IfElseResult { get; private set; }
        public string SwitchResult { get; private set; }
        public List<string> LoopResults { get; private set; }

        public ControlStructure(int inputValue)
        {
            Id = Guid.NewGuid();
            InputValue = inputValue;
            LoopResults = new List<string>();
            ProcessControlStructures();
        }

        private void ProcessControlStructures()
        {
            IfElseResult = InputValue > 0 ? "Positivo" : "Negativo";

            SwitchResult = InputValue switch
            {
                > 0 => "Valor positivo",
                0 => "Valor zero",
                _ => "Valor negativo"
            };

            for (int i = 0; i < InputValue; i++)
            {
                LoopResults.Add($"Iteração {i + 1}");
            }
        }
    }
}