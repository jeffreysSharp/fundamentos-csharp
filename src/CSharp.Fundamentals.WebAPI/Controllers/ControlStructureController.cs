using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControlStructureController : ControllerBase
    {
        private readonly ControlStructureService _service;

        public ControlStructureController(ControlStructureService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] int inputValue)
        {
            var structure = _service.Create(inputValue);
            return CreatedAtAction(nameof(GetAll), structure);
        }

        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(Guid id)
        {
            var structure = _service.GetById(id);
            return structure != null ? Ok(structure) : NotFound();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            bool deleted = _service.Delete(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}