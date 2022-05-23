using Microsoft.EntityFrameworkCore;

namespace IkeCommerce.Microservices.Api.Product.Persistence
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options) { }
        public DbSet<Product.Model.Product> Product { get; set; }
        public DbSet<Product.Model.ProductCategory> ProductCategory { get; set; }
        public DbSet<Product.Model.ProductInventory> ProductInventory { get; set; }
        public DbSet<Product.Model.ProductDiscount> ProductDiscount { get; set; }
    }
}
