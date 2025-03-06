using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{


    public class InvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;
        private readonly IMapper _mapper;

        private readonly InvestmentCalculatorService _calculatorService;

        public InvestmentService(IInvestmentRepository investmentRepository, 
                                 InvestmentCalculatorService calculatorService,
                                 IMapper mapper)
        {
            
            _investmentRepository = investmentRepository;
            _calculatorService = calculatorService;
            _mapper = mapper;
        }

        public InvestmentDto RegisterInvestment(string investorName, InvestmentType type, decimal amount, double interestRate, int durationInMonths)
        {
            var investment = new Investment(investorName, type, amount, interestRate, durationInMonths);
            decimal earnings = _calculatorService.CalculateEarnings(investment);

            _investmentRepository.Add(investment);
            return _mapper.Map<InvestmentDto>(investment);
        }
       

        public IEnumerable<InvestmentDto> GetAllInvestments()
        {
            var investments = _investmentRepository.GetAll();

            return _mapper.Map<IEnumerable<InvestmentDto>>(investments);
        }            
            

        public InvestmentDto? GetInvestmentById(Guid id) 
        {        
            var investment = _investmentRepository.GetById(id);

            return investment != null ? _mapper.Map<InvestmentDto>(investment) : null;
        } 

        public decimal GetInvestmentEarnings(Guid id)
        {
            var investment = _investmentRepository.GetById(id);
            if (investment == null) return 0;

            return _calculatorService.CalculateEarnings(investment);
        }
    }
}