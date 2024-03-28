using Microservice.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Model.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options): base(options) 
        {
                
        }

        public DbSet<Product> MyProperty { get; set; }

        public DbSet<Category> categories { get; set; }
    }
}
