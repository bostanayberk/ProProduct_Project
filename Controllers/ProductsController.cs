using Microsoft.AspNetCore.Mvc;
using Product_Project_Api.Models;

namespace Product_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        ////GET: api/Product
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetAllProduct()
        //{
        //    return await _appDbContext.Products.ToListAsync();
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProductById(int id)
        //{
        //    var product = await _appDbContext.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}

        [HttpPost]
        public async Task<ActionResult<bool>> CreateProduct(Product product)
        {


            //ürün ekleme başrılıysa detaylarını göster

            return true;
        }

        //[HttpPut]
        //public async Task<ActionResult> UpdateProduct(int id, Product product)
        //{
        //    if (id != product.Id)
        //    {
        //        return BadRequest();
        //    }
        //    _appDbContext.Entry(product).State = EntityState.Modified;
        //    try
        //    {
        //        await _appDbContext.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else throw;
        //    }
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    var product = await _appDbContext.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    _appDbContext.Remove(product);
        //    await _appDbContext.SaveChangesAsync();

        //    return NoContent();
        //}

        //[HttpDelete("truncate")]
        //public async Task<IActionResult> TruncateProduct()
        //{
        //    await _appDbContext.Database.ExecuteSqlRawAsync("TRUNCATE TABLE Products");
        //    return Ok("Bütün veriler silindi");
        //}

        //private bool ProductExists(int id)
        //{
        //    return _appDbContext.Products.Any(p => p.Id == id);
        //}
    }
}