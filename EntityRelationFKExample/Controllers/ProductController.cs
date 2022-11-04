using EntityRelationFKExample.Domain.Entities;
using EntityRelationFKExample.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntityRelationFKExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetProducts());
        }

        [HttpGet("items")]
        public async Task<IActionResult> GetItems()
        {
            return Ok(await _productService.GetProductItems());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            await _productService.AddProduct(product);
            return Created(string.Empty, product);
        }

        [HttpPost("items")]
        public async Task<IActionResult> PostItem(ProductItem productItem)
        {
            await _productService.AddProductItem(productItem);
            return Created(string.Empty, productItem);
        }
    }
}
