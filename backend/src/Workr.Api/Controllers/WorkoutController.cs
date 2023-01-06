using Microsoft.AspNetCore.Mvc;
using Workr.Api.Contracts.Workout;
using Workr.Core;

namespace Workr.Api.Controllers;

/// <summary>
/// API controller that defines endpoints for manipulating workouts.
/// </summary>
[ApiController]
[Produces("application/json")]
public sealed class WorkoutController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutController"/> class.
    /// </summary>
    public WorkoutController()
    {

    }

    /// <summary>
    /// Create a new workout.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/workout
    ///     {
    ///        "name": "john.doe@gmail.com",
    ///        "description": "John Doe",
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Workout created successfully.</response>
    /// <response code="400">Can't create workout with given parameters.</response>
    [HttpPost]
    [Route(Routes.Workout.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateWorkoutRequest request)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all workouts.
    /// </summary>
    /// <response code="200">OK</response>
    [HttpGet]
    [Route(Routes.Workout.Get)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get the workout with the specified ID.
    /// </summary>
    /// <response code="200">OK</response>
    /// <response code="404">Exercise with the given id not found.</response>
    [HttpGet]
    [Route(Routes.Workout.GetById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(string id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update the workout with the specified ID.
    /// </summary>
    [HttpPut]
    [Route(Routes.Workout.Update)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateWorkoutRequest request)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the workout with the specified ID.
    /// </summary>
    /// <response code="204">The workout has been deleted.</response>
    [HttpDelete]
    [Route(Routes.Workout.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(string id)
    {
        throw new NotImplementedException();
    }
}