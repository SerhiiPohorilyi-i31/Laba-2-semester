using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class AppDbContext : DbContext
{
    public DbSet<Recipe> Recipes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=recipes.db");
    }
}
public class DatabaseService
{
    public List<Recipe> GetRecipes()
    {
        using (var db = new AppDbContext())
        {
            return db.Recipes.ToList();
        }
    }

    public void AddRecipe(Recipe recipe)
    {
        using (var db = new AppDbContext())
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
        }
    }
}

