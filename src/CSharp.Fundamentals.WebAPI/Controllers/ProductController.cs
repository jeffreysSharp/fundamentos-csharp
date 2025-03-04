using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CreateProduct([FromBody] ProductRequest productRequest)
        {
            _productService.CreateProduct(productRequest.Name, productRequest.Price);
            return CreatedAtAction(nameof(GetProductById), new { id = productRequest.Name }, productRequest);
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
        public IActionResult UpdateProduct(Guid productId, [FromBody] ProductRequest productRequest)
        {
            var existingProduct = _productService.GetProductById(productId);

            if(existingProduct == null) return NotFound();
            
            _productService.UpdateProduct(productId, productRequest.Name, productRequest.Price);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid productId)
        {
            var existingProduct = _productService.GetProductById(productId);

            if (existingProduct == null) return NotFound();

            _productService.DeleteProduct(productId);

            return NoContent();
        }


        public record ProductRequest(string Name, decimal Price);
    }
}
