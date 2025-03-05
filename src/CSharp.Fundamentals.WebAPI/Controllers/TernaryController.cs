using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TernaryController : ControllerBase
    {
        private readonly TernaryService _ternaryService;

        public TernaryController(TernaryService ternaryService)
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
