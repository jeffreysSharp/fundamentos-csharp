using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataStructureController : ControllerBase
    {
        private readonly DataStructureService _service;

        public DataStructureController(DataStructureService service)
        {
            _service = service;
        }

        [HttpPost("generate/{size}")]
        public IActionResult GenerateLargeInvestorList(int size)
        {
            _service.GenerateLargeInvestorList(size);
            return Ok(new { Message = $"Successfully generated {size} investors." });
        }

        [HttpGet("all")]
        public IActionResult GetAllInvestors() => Ok(_service.GetAllInvestors());

        [HttpGet("array")]
        public IActionResult GetInvestorsArray() => Ok(_service.GetInvestorsArray());

        [HttpGet("list")]
        public IActionResult GetInvestorsList() => Ok(_service.GetInvestorsList());

        [HttpGet("stack")]
        public IActionResult GetInvestorsStack() => Ok(_service.GetInvestorsStack());

        [HttpGet("queue")]
        public IActionResult GetInvestorsQueue() => Ok(_service.GetInvestorsQueue());

        [HttpGet("dictionary")]
        public IActionResult GetInvestorsDictionary() => Ok(_service.GetInvestorsDictionary());

        [HttpGet("enumerable")]
        public IActionResult GetInvestorsEnumerable() => Ok(_service.GetInvestorsEnumerable());

        [HttpGet("collection")]
        public IActionResult GetInvestorsCollection() => Ok(_service.GetInvestorsCollection());

        [HttpGet("ilist")]
        public IActionResult GetInvestorsIList() => Ok(_service.GetInvestorsIList());

        [HttpGet("readonly-collection")]
        public IActionResult GetInvestorsReadOnlyCollection() => Ok(_service.GetInvestorsReadOnlyCollection());

        [HttpGet("readonly-list")]
        public IActionResult GetInvestorsReadOnlyList() => Ok(_service.GetInvestorsReadOnlyList());

        [HttpGet("idictionary")]
        public IActionResult GetInvestorsIDictionary() => Ok(_service.GetInvestorsIDictionary());
    }
}
