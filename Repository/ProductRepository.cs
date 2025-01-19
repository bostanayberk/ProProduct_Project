using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Product_Project_Api.DataContext;
using Product_Project_Api.Models;

namespace Product_Project_Api.Repository
{
    public class ProductRepository
    {
        //injection icin kullanıyoruz 
        private readonly AppDbContext _appDbContext;

        //yapici methodumuz
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        /// <summary>
        /// product eklemek icin kullandigimiz fonksiyon
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<string> AddProduct(Product product)
        {
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return product.ProductName;
        }
        /// <summary>
        /// ürün silmek için kullanıdıgımız fonksiyon
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _appDbContext.Products.FindAsync(id);
            if (product != null)
            {
                _appDbContext.Products.Remove(product);
                await _appDbContext.SaveChangesAsync();
                return true;
            }

            else
            {
                throw new Exception("ürün bulunamadı");
            }
        }

        /// <summary>
        /// ürün id sine göre ürünü  veritabanından alıp günceller
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task UpdateProduct(Product product)
        {
            var dbProduct = await _appDbContext.Products.FindAsync(product.Id);
            if (dbProduct != null)
            {
                dbProduct.ProductName = product.ProductName;
                dbProduct.Price = product.Price;
                dbProduct.Description = product.Description;

                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("ürün bulunamadı");
            }
        }

        /// <summary>
        /// id ye gore ürünleri veritabanından ürünü getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int id)
        {
            return await _appDbContext.Products.FindAsync(id);
        }
        /// <summary>
        /// ürün listesini getirir
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetProducts()
        {
            var productLists = await _appDbContext.Products.ToListAsync();
            return productLists;
        }


    }
}
