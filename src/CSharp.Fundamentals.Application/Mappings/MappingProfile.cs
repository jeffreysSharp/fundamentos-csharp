using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ArithmeticOperation, ArithmeticOperationDto>();
            CreateMap<Investment, InvestmentDto>();
            CreateMap<LogicalOperation, LogicalOperationDto>();
        }
    }
}
