using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelationalOperationController : ControllerBase
    {
        private readonly RelationalOperationService _relationalService;

        public RelationalOperationController(RelationalOperationService relationalService)
        {
            _relationalService = relationalService;
        }

        [HttpPost]
        public IActionResult PerformComparisons([FromBody] RelationalRequest request)
        {
            var operation = _relationalService.PerformComparisons(request.FirstValue, request.SecondValue);
            return CreatedAtAction(nameof(GetComparisonById), new { id = operation.Id }, operation);
        }

        [HttpGet]
        public IActionResult GetAllComparisons()
        {
            var operations = _relationalService.GetAllComparisons();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetComparisonById(Guid id)
        {
            var operation = _relationalService.GetComparisonById(id);
            if (operation == null) return NotFound();
            return Ok(operation);
        }
    }

    public record RelationalRequest(double FirstValue, double SecondValue);
}