using MediatR;
using Microsoft.AspNetCore.Mvc;
using Workr.Api.Endpoints;
using Workr.Contracts.AccessoryContracts;

namespace Workr.Api.Controllers;

[ApiController]
[Produces("application/json")]
public sealed class AccessoryController : ControllerBase
{
    private readonly ILogger<AccessoryController> _logger;
    private readonly ISender _requestSender;

    /// <summary>
    /// Initializes a new instance of the <see cref="AccessoryController"/> class.
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="requestSender"></param>
    public AccessoryController(ILogger<AccessoryController> logger, ISender requestSender)
        => (_logger, _requestSender) = (logger, requestSender);

    [HttpPost]
    [Route(Routes.Accessory.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateAccessoryRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route(Routes.Accessory.Get)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route(Routes.Accessory.Update)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(string id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route(Routes.Accessory.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(string id)
    {
        throw new NotImplementedException();
    }
}