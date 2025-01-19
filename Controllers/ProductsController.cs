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


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            if (id == null)
                return BadRequest();
            else
            {
                var deleteProduct = await _productRepository.DeleteProduct(id);

                if (deleteProduct == true)
                    return Ok(new { Message = "ürün silindi" });

                else
                    return BadRequest("bir hata meydana geldi");

            }


        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, Product product)
        {
            if (id == null)
                return BadRequest();

            var dbProduct = await _productRepository.GetProductById(id);

            if (dbProduct == null)
            {
                return NotFound(new { Message = "ürün bulunamadi" });
            }

            await _productRepository.UpdateProduct(product);
            return Ok(new { Message = "ürün güncellendi" });
        }
    }
}
