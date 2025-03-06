using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FunctionController : ControllerBase
    {
        private readonly FunctionService _functionService;

        public FunctionController(FunctionService functionService)
        {
            _functionService = functionService;
        }

        [HttpGet("add/{a}/{b}")]
        public IActionResult Add(int a, int b) => Ok(_functionService.Add(a, b));

        [HttpPost("create/{value}")]
        public IActionResult Create(int value)
        {
            var example = _functionService.CreateFunction(value);
            return CreatedAtAction(nameof(GetAll), example);
        }

        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(_functionService.GetAll());

        [HttpGet("async-data")]
        public async Task<IActionResult> GetAsyncData() => Ok(await _functionService.GetDataAsync());

        [HttpGet("multiply/{a}/{b}")]
        public IActionResult Multiply(int a, int b) => Ok(FunctionService.Multiply(a, b));
    }
}
