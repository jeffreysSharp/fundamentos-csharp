namespace CSharp.Fundamentals.Domain.Entities
{
    public class LogicalOperation
    {
        public Guid Id { get; private set; }
        public bool FirstCondition { get; private set; }
        public bool SecondCondition { get; private set; }
        public bool AndResult { get; private set; }
        public bool OrResult { get; private set; }
        public bool NotFirst { get; private set; }
        public bool NotSecond { get; private set; }

        public LogicalOperation(bool firstCondition, bool secondCondition)
        {
            Id = Guid.NewGuid();
            FirstCondition = firstCondition;
            SecondCondition = secondCondition;
            AndResult = firstCondition && secondCondition;
            OrResult = firstCondition || secondCondition;
            NotFirst = !firstCondition;
            NotSecond = !secondCondition;
        }
    }
}
