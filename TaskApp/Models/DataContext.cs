using Microsoft.EntityFrameworkCore;

namespace TaskApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}