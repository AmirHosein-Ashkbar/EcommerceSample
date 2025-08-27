using EcommerceSample.Application.Contracts;
using EcommerceSample.Application.Wrappers;
using Entity = EcommerceSample.Domain.Entities;
using MediatR;

namespace EcommerceSample.Application.Usecases.Order;
public record OrderCommand(int ProductId, int Quantity) : IRequest<Result<bool>>;

public class OrderCommandHandler(IOrderRepository orderRepository)
    : IRequestHandler<OrderCommand, Result<bool>>
{
    public async Task<Result<bool>> Handle(OrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Entity.Order
        {
            ProductId = request.ProductId,
            Quantity = request.Quantity
        };
        var isAdded = orderRepository.Add(order);
        return Result<bool>.Success(isAdded);
    }
}
