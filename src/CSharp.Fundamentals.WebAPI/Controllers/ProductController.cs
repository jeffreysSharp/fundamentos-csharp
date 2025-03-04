using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Guid id, [FromBody] Product product)
        {
            var existingProduct = _productService.GetProductById(id);

            if (existingProduct == null) return NotFound();

            _productService.UpdateProduct(id, product.Name, product.Price);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var existingProduct = _productService.GetProductById(id);

            if (existingProduct == null) return NotFound();

            _productService.DeleteProduct(id);

            return NoContent();
        }
    }
}
