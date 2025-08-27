using EcommerceSample.Domain.Entities;
using EcommerceSample.Infrastructure.Presistance;

namespace EcommerceSample.Api;

public static class DBSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.Products.Any())
        {
            var products = new List<Product>();

            for (int i = 1; i <= 20; i++)
            {
                products.Add(new Product
                {
                    Name = $"Product {i}",
                    Price = 10 * i,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true,
                    IsDeleted = false
                });
            }

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }
}
