using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class NumericDataService
    {
        private readonly INumericDataRepository _repository;
        private readonly NumericCalculatorService _calculator;

        public NumericDataService(INumericDataRepository repository, NumericCalculatorService calculator)
        {
            _repository = repository;
            _calculator = calculator;
        }

        public NumericDataExample RegisterNumericData(NumericDataExample data)
        {
            _repository.Add(data);
            return data;
        }

        public IEnumerable<NumericDataExample> GetAllNumericData() => _repository.GetAll();

        public NumericDataExample? GetNumericDataById(Guid id) => _repository.GetById(id);

        public NumericDataExample PerformCalculations(Guid id)
        {
            var data = _repository.GetById(id);
            return data != null ? _calculator.PerformCalculations(data) : null;
        }
    }
}