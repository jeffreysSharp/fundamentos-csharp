using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class TernaryService
    {
        private readonly ITernaryRepository _repository;
        private readonly IMapper _mapper;

        public TernaryService(ITernaryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TernaryOperationsDto EvaluateTernaryExpression(int value)
        {
            var operation = new TernaryOperation(value);

            _repository.Add(operation);
            return _mapper.Map<TernaryOperationsDto>(operation);
        }

        public IEnumerable<TernaryOperationsDto> GetAllOperations()
        {
            var ternaryOperations = _repository.GetAll();

            return _mapper.Map<IEnumerable<TernaryOperationsDto>>(ternaryOperations);
        }

        public TernaryOperationsDto? GetOperationById(Guid id)
        {
            var ternaryOperation = _repository.GetById(id);

            return _mapper.Map<TernaryOperationsDto>(ternaryOperation);
        }
    }
}
