using EcommerceSample.Application.Contracts;
using EcommerceSample.Domain.Entities;

namespace EcommerceSample.Infrastructure.Presistance.Repositories;
public class OrderRepository : GenericRepository<Order> , IOrderRepository 
{
    public OrderRepository(AppDbContext context) : base(context) { }
}

