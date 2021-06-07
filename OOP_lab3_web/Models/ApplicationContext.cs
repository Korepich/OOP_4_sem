using Microsoft.EntityFrameworkCore;

namespace OOP_lab3_web.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
