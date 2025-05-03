using Microsoft.EntityFrameworkCore;

namespace Lab9_task21.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
    }
}
