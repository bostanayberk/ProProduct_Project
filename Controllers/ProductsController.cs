using Microsoft.AspNetCore.Mvc;
using Product_Project_Api.Models;
using Product_Project_Api.Repository;

namespace Product_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateProduct(Product product)
        {
            if (product == null)
                return BadRequest();

            var createdProduct = await _productRepository.AddProduct(product);

            return Ok(createdProduct);

        }

    }
}