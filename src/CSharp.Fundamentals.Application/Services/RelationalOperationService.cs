using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;
  
namespace CSharp.Fundamentals.Application.Services
{
    public class RelationalOperationService
    {
        private readonly IRelationalRepository _repository;
        private readonly IMapper _mapper;

        public RelationalOperationService(IRelationalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public RelationalOperationDto PerformComparisons(double firstValue, double secondValue)
        {
            var relationalOperation = new RelationalOperation(firstValue, secondValue);
            _repository.Add(relationalOperation);

            return _mapper.Map<RelationalOperationDto>(relationalOperation);
        }

        public IEnumerable<RelationalOperationDto> GetAllComparisons()
        {
            var relationalOperations = _repository.GetAll();

            return _mapper.Map<IEnumerable<RelationalOperationDto>>(relationalOperations);
        }

        public RelationalOperationDto? GetComparisonById(Guid id)
        {
            var relationalOperation = _repository.GetById(id);

            return _mapper.Map<RelationalOperationDto>(relationalOperation);
        }
    }
}