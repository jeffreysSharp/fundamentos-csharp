using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ArithmeticOperation, ArithmeticOperationDto>().ReverseMap();
            CreateMap<Investment, InvestmentDto>().ReverseMap();
            CreateMap<LogicalOperation, LogicalOperationDto>().ReverseMap();
            CreateMap<NumericalData, NumericalDataDto>().ReverseMap();
            CreateMap<RelationalOperation, RelationalOperationDto>().ReverseMap();
            CreateMap<TernaryOperation, TernaryOperationDto>().ReverseMap();
            CreateMap<Investor, InvestorDto>().ReverseMap();
            CreateMap<Function, FunctionDto>().ReverseMap();
            CreateMap<ControlStructure, ControlStructureDto>().ReverseMap();
        }
    }
}
