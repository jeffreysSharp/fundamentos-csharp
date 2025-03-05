using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class TernaryService
    {
        private readonly ITernaryRepository _repository;

        public TernaryService(ITernaryRepository repository)
        {
            _repository = repository;
        }

        public TernaryOperation EvaluateTernaryExpression(int value)
        {
            var operation = new TernaryOperation(value);
            _repository.Add(operation);
            return operation;
        }

        public IEnumerable<TernaryOperation> GetAllOperations() => _repository.GetAll();

        public TernaryOperation? GetOperationById(Guid id) => _repository.GetById(id);
    }
}
