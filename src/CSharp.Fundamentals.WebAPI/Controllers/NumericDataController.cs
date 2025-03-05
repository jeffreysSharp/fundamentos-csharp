using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumericDataController : ControllerBase
    {
        private readonly NumericDataService _numericDataService;

        public NumericDataController(NumericDataService numericDataService)
        {
            _numericDataService = numericDataService;
        }

        [HttpPost]
        public IActionResult RegisterNumericData([FromBody] NumericDataExample data)
        {
            var savedData = _numericDataService.RegisterNumericData(data);
            return CreatedAtAction(nameof(GetNumericDataById), new { id = savedData.Id }, savedData);
        }

        [HttpGet]
        public IActionResult GetAllNumericData()
        {
            var dataList = _numericDataService.GetAllNumericData();
            return Ok(dataList);
        }

        [HttpGet("{id}")]
        public IActionResult GetNumericDataById(Guid id)
        {
            var data = _numericDataService.GetNumericDataById(id);
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpGet("{id}/calculate")]
        public IActionResult PerformCalculations(Guid id)
        {
            var updatedData = _numericDataService.PerformCalculations(id);
            return updatedData != null ? Ok(updatedData) : NotFound();
        }
    }
}