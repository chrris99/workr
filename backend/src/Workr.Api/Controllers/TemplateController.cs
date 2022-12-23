using Microsoft.AspNetCore.Mvc;
using Workr.Api.Contracts.Workout;
using Workr.Domain.Abstractions;

namespace Workr.Api.Controllers;

/// <summary>
/// API controller that defines endpoints for manipulating workout templates.
/// </summary>
[ApiController]
[Produces("application/json")]
public sealed class TemplateController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TemplateController"/> class.
    /// </summary>
    public TemplateController() { }
    
    /// <summary>
    /// Create a new workout template.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/template
    ///     {
    ///        "name": "john.doe@gmail.com",
    ///        "description": "John Doe",
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Workout created successfully.</response>
    /// <response code="400">Can't create workout with given parameters.</response>
    [HttpPost]
    [Route(Routes.Template.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateWorkoutRequest request)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get all workout templates.
    /// </summary>
    /// <response code="200">OK</response>
    [HttpGet]
    [Route(Routes.Template.Get)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the workout template with the specified ID.
    /// </summary>
    /// <response code="200">OK</response>
    /// <response code="404">Workout template with the given id not found.</response>
    [HttpGet]
    [Route(Routes.Template.GetById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(string id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update the workout template with the specified ID.
    /// </summary>
    [HttpPut]
    [Route(Routes.Template.Update)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateWorkoutRequest request)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the workout template with the specified ID.
    /// </summary>
    /// <response code="204">The workout template has been deleted.</response>
    [HttpDelete]
    [Route(Routes.Template.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(string id)
    {
        throw new NotImplementedException();
    }
}