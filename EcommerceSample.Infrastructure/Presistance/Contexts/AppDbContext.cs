using EcommerceSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceSample.Infrastructure.Presistance;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Order> Orders => Set<Order>();


}
