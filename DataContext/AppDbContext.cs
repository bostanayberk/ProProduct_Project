using Microsoft.EntityFrameworkCore;
using Product_Project_Api.Models;

namespace Product_Project_Api.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}