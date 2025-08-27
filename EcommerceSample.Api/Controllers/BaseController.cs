using EcommerceSample.Application.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSample.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class BaseController : ControllerBase
{
    private ISender _mediator;
    private ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

    protected async Task<ObjectResult> SendAsync<T>(IRequest<Result<T>> request, CancellationToken ct = default)
    {
        var result = await Mediator.Send(request, ct);

        if (result.IsSuccess)
            return Ok(result);

        return Ok(result);

    }

    protected async Task<Result<T>> SendDirectAsync<T>(IRequest<Result<T>> request, CancellationToken ct = default)
        => await Mediator.Send(request, ct);

    //protected async Task<ObjectResult> SendAsync(IRequest<Response<object>> request, CancellationToken ct = default)
    //    => await SendAsync<object>(request, ct);

    //protected async Task<ObjectResult> SendAsync(IRequest<Response<Guid>> request, CancellationToken ct = default)
    //    => await SendAsync<Guid>(request, ct);

    //protected async Task<ObjectResult> SendAsync(IRequest<Response<int>> request, CancellationToken ct = default)
    //    => await SendAsync<int>(request, ct);

    //protected async Task<ObjectResult> SendAsync(IRequest<Response<long>> request, CancellationToken ct = default)
    //    => await SendAsync<long>(request, ct);
}
