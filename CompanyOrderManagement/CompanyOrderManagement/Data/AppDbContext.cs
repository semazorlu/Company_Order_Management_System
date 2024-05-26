using Microsoft.EntityFrameworkCore;

namespace CompanyOrderManagement.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Models.Company> Companies { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JDK13S7;Initial Catalog=COM;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
