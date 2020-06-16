using Microsoft.EntityFrameworkCore;
using ShopCET46.WEB.Data.Entities;

namespace ShopCET46.WEB.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
