using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class NumericalDataService
    {
        private readonly INumericalDataRepository _repository;
        private readonly IMapper _mapper;
        private readonly NumericCalculatorService _calculator;

        public NumericalDataService(INumericalDataRepository repository,
                                  NumericCalculatorService calculator,
                                  IMapper mapper)
        {
            _repository = repository;
            _calculator = calculator;
            _mapper = mapper;
        }

        public NumericalDataDto RegisterNumericData(sbyte smallValue, byte byteValue, short shortValue,
            ushort ushortValue, int intValue, uint uintValue, long longValue,
            ulong ulongValue, float floatValue, double doubleValue, decimal decimalValue)
        {
            var numericData = new NumericalData(smallValue, byteValue, shortValue,
            ushortValue, intValue, uintValue, longValue,
            ulongValue, floatValue, doubleValue, decimalValue);

            _repository.Add(numericData);
            return _mapper.Map<NumericalDataDto>(numericData);
        }

        public IEnumerable<NumericalDataDto> GetAllNumericData()
        {
            var numeriDatas = _repository.GetAll();

            return _mapper.Map<IEnumerable<NumericalDataDto>>(numeriDatas);
        }


        public NumericalDataDto? GetNumericDataById(Guid id)
        {            
            var numericData = _repository.GetById(id);

            return _mapper.Map<NumericalDataDto>(numericData);

        }        
        public NumericalData? PerformCalculations(Guid id)
        {
            var data = _repository.GetById(id);
            return data != null ? _calculator.PerformCalculations(data) : null;
        }
    }
}