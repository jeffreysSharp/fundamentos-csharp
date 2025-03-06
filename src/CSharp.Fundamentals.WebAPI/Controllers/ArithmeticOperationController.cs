using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArithmeticOperationController : ControllerBase
    {
        private readonly ArithmeticOperationService _arithmeticService;

        public ArithmeticOperationController(ArithmeticOperationService arithmeticService)
        {
            _arithmeticService = arithmeticService;
        }

        [HttpPost]
        public IActionResult PerformOperations([FromBody] ArithmeticRequest request)
        {
            var result = _arithmeticService.PerformOperations(request.FirstNumber, request.SecondNumber);
            return CreatedAtAction(nameof(GetOperationById), new { id = result }, result);
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
