using EcommerceSample.Application.Contracts;
using EcommerceSample.Domain.Entities;

namespace EcommerceSample.Infrastructure.Presistance.Repositories;
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context): base(context) {}


}
