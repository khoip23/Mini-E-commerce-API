using MEC.Models;
using Microsoft.EntityFrameworkCore;
namespace MEC.Data
{
    public class MecDbContext : DbContext
    {
        public MecDbContext(DbContextOptions<MecDbContext> options) : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
