using EcommerceSample.Application.Contracts;
using EcommerceSample.Application.Wrappers;
using Entity = EcommerceSample.Domain.Entities;
using MediatR;
using EcommerceSample.Application.Usecases.Order.Dto;

namespace EcommerceSample.Application.Usecases.Order.Queries;
public record GetAllOrdersQuery() : IRequest<Result<object>>;

public class GetAllOrdersQueryHandler(IGenericRepository<Entity.Order> orderRepository, IGenericRepository<Entity.Product> productRepository) : IRequestHandler<GetAllOrdersQuery, Result<object>>
{

    public async Task<Result<object>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await orderRepository.GetAll();
        var ordersDto = orders.Select(o => new OrderDto(o.ProductId, o.Quantity, o.CreatedAt));
        return Result<object>.Success(ordersDto);
    }
}


