using EcommerceSample.Application.Usecases.Order;
using EcommerceSample.Application.Usecases.Order.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EcommerceSample.Api.Controllers;
public class OrderController : BaseController
{
    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Order([FromBody] OrderCommand command, CancellationToken ct = default)
        => await SendAsync<bool>(command, ct);

    [HttpGet]
    [Route("GetAll")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAll(CancellationToken ct = default)
            => await SendAsync(new GetAllOrdersQuery(), ct);
}

