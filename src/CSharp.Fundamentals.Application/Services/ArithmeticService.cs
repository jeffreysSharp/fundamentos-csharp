using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class ArithmeticService
    {
        private readonly IArithmeticRepository _repository;

        public ArithmeticService(IArithmeticRepository repository)
        {
            _repository = repository;
        }

        public ArithmeticOperation PerformOperations(double firstNumber, double secondNumber)
        {
            var operation = new ArithmeticOperation(firstNumber, secondNumber);
            _repository.Add(operation);
            return operation;
        }

        public IEnumerable<ArithmeticOperation> GetAllOperations() => _repository.GetAll();

        public ArithmeticOperation? GetOperationById(Guid id) => _repository.GetById(id);
    }
}
