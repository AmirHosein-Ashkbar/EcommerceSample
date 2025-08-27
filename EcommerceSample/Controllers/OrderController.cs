using EcommerceSample.Application.Usecases.Order;
using EcommerceSample.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EcommerceSample.Presentation.Controllers;
public class OrderController : BaseController
{
    [HttpPost]
    [Route("Order")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Order([FromBody] OrderCommand command, CancellationToken ct = default)
        => await SendAsync<bool>(command, ct);


  
}
