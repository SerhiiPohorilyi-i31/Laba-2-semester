using Lab9_task21.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Lab9_task21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Реєстрація DbContext з In-Memory базою
            builder.Services.AddDbContext<AppDbContext>(opt =>
            opt.UseInMemoryDatabase("DishesDB"));

            // Swagger 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            // Ініціалізація БД
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();
            }


            // Swagger UI
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

           
            // Rest endpoints:
            // Отримати всі страви
            app.MapGet("/dishes", async (AppDbContext db) =>
                await db.Dishes.ToListAsync());

            // Отримати страву за ID
            app.MapGet("/dishes/{id}", async (int id, AppDbContext db) =>
                await db.Dishes.FindAsync(id) is Dish dish ? Results.Ok(dish) : Results.NotFound());

            // Додати нову страву
            app.MapPost("/dishes", async (Dish dish, AppDbContext db) =>
            {
                db.Dishes.Add(dish);
                await db.SaveChangesAsync();
                return Results.Created($"/dishes/{dish.Id}", dish);
            });

            // Оновити наявну страву
            app.MapPut("/dishes/{id}", async (int id, Dish updatedDish, AppDbContext db) =>
            {
                var dish = await db.Dishes.FindAsync(id);
                if (dish == null) return Results.NotFound();

                dish.Name = updatedDish.Name;
                dish.Category = updatedDish.Category;
                dish.Ingredients = updatedDish.Ingredients;
                dish.Rating = updatedDish.Rating;

                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            // Видалити страву
            app.MapDelete("/dishes/{id}", async (int id, AppDbContext db) =>
            {
                var dish = await db.Dishes.FindAsync(id);
                if (dish == null) return Results.NotFound();

                db.Dishes.Remove(dish);
                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            app.Run();

        }
    }
}
