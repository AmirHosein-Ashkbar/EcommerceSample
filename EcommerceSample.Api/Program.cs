using EcommerceSample.Api;
using EcommerceSample.Application;
using EcommerceSample.Infrastructure;
using EcommerceSample.Infrastructure.Presistance;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services
    .AddSwaggerGen()
    .AddApplication()
    .AddInfrastructure();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
    await DBSeeder.SeedAsync(dbContext);
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
