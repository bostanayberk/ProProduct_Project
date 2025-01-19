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
    }
}
