using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class ArithmeticService
    {
        private readonly IArithmeticRepository _arithmeticRepository;
        private readonly IMapper _mapper;

        public ArithmeticService(IArithmeticRepository repository, IMapper mapper)
        {
            _arithmeticRepository = repository;
            _mapper = mapper;
        }

        public ArithmeticOperationDto PerformOperations(double firstNumber, double secondNumber)
        {
            var operation = new ArithmeticOperation(firstNumber, secondNumber);
            _arithmeticRepository.Add(operation);
            return _mapper.Map<ArithmeticOperationDto>(operation);
        }

        public IEnumerable<ArithmeticOperationDto> GetAllOperations()
        {
            var operations = _arithmeticRepository.GetAll();
            return _mapper.Map<IEnumerable<ArithmeticOperationDto>>(operations);
        }

        public ArithmeticOperationDto? GetOperationById(Guid id)
        {
            var operation = _arithmeticRepository.GetById(id);
            return operation != null ? _mapper.Map<ArithmeticOperationDto>(operation) : null;
        }
        
    }
}
