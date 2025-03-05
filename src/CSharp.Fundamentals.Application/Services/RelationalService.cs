using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class RelationalService
    {
        private readonly IRelationalRepository _repository;

        public RelationalService(IRelationalRepository repository)
        {
            _repository = repository;
        }

        public RelationalOperation PerformComparisons(double firstValue, double secondValue)
        {
            var operation = new RelationalOperation(firstValue, secondValue);
            _repository.Add(operation);
            return operation;
        }

        public IEnumerable<RelationalOperation> GetAllComparisons() => _repository.GetAll();

        public RelationalOperation? GetComparisonById(Guid id) => _repository.GetById(id);
    }
}