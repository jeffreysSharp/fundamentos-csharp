using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArithmeticController : ControllerBase
    {
        private readonly ArithmeticService _arithmeticService;

        public ArithmeticController(ArithmeticService arithmeticService)
        {
            _arithmeticService = arithmeticService;
        }

        [HttpPost]
        public IActionResult PerformOperations([FromBody] ArithmeticRequest request)
        {
            var operation = _arithmeticService.PerformOperations(request.FirstNumber, request.SecondNumber);
            return CreatedAtAction(nameof(GetOperationById), new { id = operation.Id }, operation);
        }

        [HttpGet]
        public IActionResult GetAllOperations()
        {
            var operations = _arithmeticService.GetAllOperations();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOperationById(Guid id)
        {
            var operation = _arithmeticService.GetOperationById(id);
            if (operation == null) return NotFound();
            return Ok(operation);
        }
    }

    public record ArithmeticRequest(double FirstNumber, double SecondNumber);
}
