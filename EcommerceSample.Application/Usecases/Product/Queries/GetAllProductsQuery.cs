using EcommerceSample.Application.Contracts;
using EcommerceSample.Application.Wrappers;
using Entity = EcommerceSample.Domain.Entities;
using MediatR;

namespace EcommerceSample.Application.Usecases.Product;
public record GetAllProductsQuery() : IRequest<Result<object>>;



public class GetAllProductsQueryHandler(IGenericRepository<Entity.Product> productRepository) : IRequestHandler<GetAllProductsQuery, Result<object>>
{
    
    public async Task<Result<object>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAll();
        var productsDto = products.Select(p => new ProductDto(p.Id, p.Name, p.Price));

        return Result<object>.Success(productsDto);
    }
}
