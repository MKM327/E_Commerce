using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace E_CommerceAPI.Contexts
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions options) : base(options)
        {

        }

        public ECommerceContext()
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
