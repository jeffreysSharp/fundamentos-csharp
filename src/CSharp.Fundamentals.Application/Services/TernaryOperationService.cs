using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class TernaryOperationService
    {
        private readonly ITernaryRepository _repository;
        private readonly IMapper _mapper;

        public TernaryOperationService(ITernaryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TernaryOperationDto EvaluateTernaryExpression(int value)
        {
            var operation = new TernaryOperation(value);

            _repository.Add(operation);
            return _mapper.Map<TernaryOperationDto>(operation);
        }

        public IEnumerable<TernaryOperationDto> GetAllOperations()
        {
            var ternaryOperations = _repository.GetAll();

            return _mapper.Map<IEnumerable<TernaryOperationDto>>(ternaryOperations);
        }

        public TernaryOperationDto? GetOperationById(Guid id)
        {
            var ternaryOperation = _repository.GetById(id);

            return _mapper.Map<TernaryOperationDto>(ternaryOperation);
        }
    }
}
