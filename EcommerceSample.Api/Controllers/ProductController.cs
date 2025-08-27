using EcommerceSample.Application.Usecases.Product;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EcommerceSample.Api.Controllers;
public class ProductController : BaseController
{
    [HttpGet]
    [Route("GetAll")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAll(CancellationToken ct = default)
            => await SendAsync(new GetAllProductsQuery(), ct);
}
