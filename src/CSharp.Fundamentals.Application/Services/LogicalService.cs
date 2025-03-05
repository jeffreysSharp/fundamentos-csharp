using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class LogicalService
    {
        private readonly ILogicalRepository _repository;

        public LogicalService(ILogicalRepository repository)
        {
            _repository = repository;
        }

        public LogicalOperation PerformLogicalOperations(bool firstCondition, bool secondCondition)
        {
            var operation = new LogicalOperation(firstCondition, secondCondition);
            _repository.Add(operation);
            return operation;
        }

        public IEnumerable<LogicalOperation> GetAllOperations() => _repository.GetAll();

        public LogicalOperation? GetOperationById(Guid id) => _repository.GetById(id);
    }
}
