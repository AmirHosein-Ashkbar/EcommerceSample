using EcommerceSample.Application.Usecases.Order;
using FluentValidation;

namespace EcommerceSample.Application.Usecases.Order;
public class OrderCommandValidator : AbstractValidator<OrderCommand>
{
    public OrderCommandValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.Quantity).GreaterThan(0);
    }
}
