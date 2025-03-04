using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentController : ControllerBase
    {
        private readonly InvestmentService _investmentService;

        public InvestmentController(InvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpPost]
        public IActionResult RegisterInvestment([FromBody] InvestmentRequest request)
        {
            var investment = _investmentService.RegisterInvestment(request.InvestorName, request.Type, request.Amount, request.InterestRate, request.DurationInMonths);
            return CreatedAtAction(nameof(GetInvestmentById), new { id = investment.Id }, investment);
        }

        [HttpGet]
        public IActionResult GetAllInvestments()
        {
            var investments = _investmentService.GetAllInvestments();
            return Ok(investments);
        }

        [HttpGet("{id}")]
        public IActionResult GetInvestmentById(Guid id)
        {
            var investment = _investmentService.GetInvestmentById(id);
            if (investment == null) return NotFound();
            return Ok(investment);
        }

        [HttpGet("{id}/earnings")]
        public IActionResult GetInvestmentEarnings(Guid id)
        {
            var earnings = _investmentService.GetInvestmentEarnings(id);
            return Ok(new { Earnings = earnings });
        }
    }

    public record InvestmentRequest(string InvestorName, InvestmentType Type, decimal Amount, double InterestRate, int DurationInMonths);
}