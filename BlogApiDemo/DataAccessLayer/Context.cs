using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9E5P6SH;database=CoreBlogApiDb;integrated security=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
