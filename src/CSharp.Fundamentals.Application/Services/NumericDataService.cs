using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class NumericDataService
    {
        private readonly INumericDataRepository _repository;
        private readonly IMapper _mapper;
        private readonly NumericCalculatorService _calculator;

        public NumericDataService(INumericDataRepository repository,
                                  NumericCalculatorService calculator,
                                  IMapper mapper)
        {
            _repository = repository;
            _calculator = calculator;
            _mapper = mapper;
        }

        public NumericDataDto RegisterNumericData(sbyte smallValue, byte byteValue, short shortValue,
            ushort ushortValue, int intValue, uint uintValue, long longValue,
            ulong ulongValue, float floatValue, double doubleValue, decimal decimalValue)
        {
            var numericData = new NumericData(smallValue, byteValue, shortValue,
            ushortValue, intValue, uintValue, longValue,
            ulongValue, floatValue, doubleValue, decimalValue);

            _repository.Add(numericData);
            return _mapper.Map<NumericDataDto>(numericData);
        }

        public IEnumerable<NumericDataDto> GetAllNumericData()
        {
            var numeriDatas = _repository.GetAll();

            return _mapper.Map<IEnumerable<NumericDataDto>>(numeriDatas);
        }


        public NumericDataDto? GetNumericDataById(Guid id)
        {            
            var numericData = _repository.GetById(id);

            return _mapper.Map<NumericDataDto>(numericData);

        }        
        public NumericData? PerformCalculations(Guid id)
        {
            var data = _repository.GetById(id);
            return data != null ? _calculator.PerformCalculations(data) : null;
        }
    }
}