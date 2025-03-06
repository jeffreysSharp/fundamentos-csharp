using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp.Fundamentals.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ArithmeticOperation, ArithmeticOperationDto>();
        }
    }
}
