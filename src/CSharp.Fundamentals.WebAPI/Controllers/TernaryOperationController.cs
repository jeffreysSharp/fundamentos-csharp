using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TernaryOperationController : ControllerBase
    {
        private readonly TernaryOperationService _ternaryService;

        public TernaryOperationController(TernaryOperationService ternaryService)
        {
            _ternaryService = ternaryService;
        }

        [HttpPost]
        public IActionResult EvaluateTernaryExpression([FromBody] TernaryRequest request)
        {
            var operation = _ternaryService.EvaluateTernaryExpression(request.Value);
            return CreatedAtAction(nameof(GetOperationById), new { id = operation.Id }, operation);
        }

        [HttpGet]
        public IActionResult GetAllOperations()
        {
            var operations = _ternaryService.GetAllOperations();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOperationById(Guid id)
        {
            var operation = _ternaryService.GetOperationById(id);
            if (operation == null) return NotFound();
            return Ok(operation);
        }
    }

    public record TernaryRequest(int Value);
}
