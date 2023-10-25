using Microsoft.EntityFrameworkCore;

namespace CrudOperationsInDotNetCore.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)   // constructor
        {

            
        }
        public DbSet<Brand> Brands { get; set; }
    }
}
