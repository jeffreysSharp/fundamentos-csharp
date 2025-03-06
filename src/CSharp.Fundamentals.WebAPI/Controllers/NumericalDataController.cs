using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumericalDataController : ControllerBase
    {
        private readonly NumericalDataService _numericDataService;

        public NumericalDataController(NumericalDataService numericDataService)
        {
            _numericDataService = numericDataService;
        }

        [HttpPost]
        public IActionResult RegisterNumericData([FromBody] NumericDataRequest request)
        {
            var numericData = _numericDataService.RegisterNumericData(request.smallValue, request.byteValue, request.shortValue,
            request.ushortValue, request.intValue, request.uintValue, request.longValue,
            request.ulongValue, request.floatValue, request.doubleValue, request.decimalValue);

            return CreatedAtAction(nameof(GetNumericDataById), new { id = numericData.Id }, numericData);
        }

        [HttpGet]
        public IActionResult GetAllNumericData()
        {
            var numericDatas = _numericDataService.GetAllNumericData();
            return Ok(numericDatas);
        }

        [HttpGet("{id}")]
        public IActionResult GetNumericDataById(Guid id)
        {
            var numericData = _numericDataService.GetNumericDataById(id);
            if (numericData == null) return NotFound();

            return Ok(numericData);
        }

        [HttpGet("{id}/calculate")]
        public IActionResult PerformCalculations(Guid id)
        {
            var updatedData = _numericDataService.PerformCalculations(id);

            return updatedData != null ? Ok(updatedData) : NotFound();
        }

        public record NumericDataRequest(sbyte smallValue, byte byteValue, short shortValue,
            ushort ushortValue, int intValue, uint uintValue, long longValue,
            ulong ulongValue, float floatValue, double doubleValue, decimal decimalValue);
    }
}