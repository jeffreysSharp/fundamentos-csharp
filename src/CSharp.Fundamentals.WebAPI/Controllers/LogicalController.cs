using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogicalController : ControllerBase
    {
        private readonly LogicalService _logicalService;

        public LogicalController(LogicalService logicalService)
        {
            _logicalService = logicalService;
        }

        [HttpPost]
        public IActionResult PerformLogicalOperations([FromBody] LogicalRequest request)
        {
            var operation = _logicalService.PerformLogicalOperations(request.FirstCondition, request.SecondCondition);
            return CreatedAtAction(nameof(GetOperationById), new { id = operation.Id }, operation);
        }

        [HttpGet]
        public IActionResult GetAllOperations()
        {
            var operations = _logicalService.GetAllOperations();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOperationById(Guid id)
        {
            var operation = _logicalService.GetOperationById(id);
            if (operation == null) return NotFound();
            return Ok(operation);
        }
    }

    public record LogicalRequest(bool FirstCondition, bool SecondCondition);
}
