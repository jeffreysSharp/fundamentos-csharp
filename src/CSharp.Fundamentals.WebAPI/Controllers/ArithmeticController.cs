using CSharp.Fundamentals.Application.Services;
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

        [HttpGet("add")]
        public IActionResult Add(int a, int b) => Ok(new { Result = _arithmeticService.Add(a, b) });

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) => Ok(new { Result = _arithmeticService.Subtract(a, b) });

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b) => Ok(new { Result = _arithmeticService.Multiply(a, b) });

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            try
            {
                return Ok(new { Result = _arithmeticService.Divide(a, b) });
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet("modulus")]
        public IActionResult Modulus(int a, int b) => Ok(new { Result = _arithmeticService.Modulus(a, b) });

        [HttpGet("increment")]
        public IActionResult Increment(int value)
        {
            int newValue = value;
            _arithmeticService.Increment(ref newValue);
            return Ok(new { Original = value, Incremented = newValue });
        }

        [HttpGet("decrement")]
        public IActionResult Decrement(int value)
        {
            int newValue = value;
            _arithmeticService.Decrement(ref newValue);
            return Ok(new { Original = value, Decremented = newValue });
        }
    }
}