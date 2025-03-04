using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductRequest request)
        {
            _productService.RegisterProduct(request.Name, request.Price);
            return CreatedAtAction(nameof(GetById), new { id = request.Name }, request);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }


        public record ProductRequest(string Name, decimal Price);
    }
}
