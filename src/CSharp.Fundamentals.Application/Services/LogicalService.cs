using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class LogicalService
    {
        private readonly ILogicalRepository _repository;
        private readonly IMapper _mapper;

        public LogicalService(ILogicalRepository repository, 
                              IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public LogicalOperationDto PerformLogicalOperations(bool firstCondition, bool secondCondition)
        {
            var operation = new LogicalOperation(firstCondition, secondCondition);
            _repository.Add(operation);

            return _mapper.Map<LogicalOperationDto>(operation);
        }

        public IEnumerable<LogicalOperationDto> GetAllOperations()
        {
            var logicalOperations = _repository.GetAll();

            return _mapper.Map<IEnumerable<LogicalOperationDto>>(logicalOperations);
        }
            

        public LogicalOperationDto? GetOperationById(Guid id)
        {
            var logicalOperation = _repository.GetById(id);

            return logicalOperation != null ? _mapper.Map<LogicalOperationDto>(logicalOperation) : null;

        }   
    }
}
