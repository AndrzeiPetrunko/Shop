using Microsoft.EntityFrameworkCore;
using Shop.Entities;

namespace Shop
{
    public class ShopDbContext : DbContext
    {
        private IConfiguration _configuration { get; }
        public DbSet<Products> Products { get; set; }
       public  DbSet<ProductCategory> ProductCategories { get; set; }
        public ShopDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=Shop;trusted_connection=true;", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Shop"));
        }

    }
}

