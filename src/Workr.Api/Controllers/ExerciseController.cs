using MediatR;
using Microsoft.AspNetCore.Mvc;
using Workr.Api.Contracts.Exercise;
using Workr.Api.Endpoints;
using Workr.Application.Commands.CreateExercise;
using Workr.Application.Queries;
using Workr.Core;

namespace Workr.Api.Controllers;

/// <summary>
/// API controller that defines endpoints for manipulating exercises.
/// </summary>
[ApiController]
[Produces("application/json")]
public sealed class ExerciseController : ControllerBase
{
    private readonly ISender _requestSender;

    /// <summary>
    ///
    /// </summary>
    /// <param name="requestSender"></param>
    public ExerciseController(ISender requestSender) => _requestSender = requestSender;

    /// <summary>
    /// Create a new exercise.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/exercise
    ///     {
    ///        "name": "Bench press",
    ///        "description": "Lie down on a flat bench with your feet on the floor and your back straight. Grasp the barbell or dumbbells with an overhand grip, slightly wider than shoulder-width apart. Lower the weight slowly towards your chest, keeping your elbows close to your body, then pause and push the weight back up to the starting position.",
    ///        "type": "weighted"
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Exercise created successfully.</response>
    /// <response code="400">Can't create exercise with given parameters.</response>
    [HttpPost]
    [Route(Routes.Exercise.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateExerciseRequest request)
    {
        var command = new CreateExerciseCommand(
            request.Name,
            request.Description,
            request.Type,
            request.RequiredAccessories,
            request.TargetMuscleGroups);

        var result = await _requestSender.Send(command);

        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }

    /// <summary>
    /// Get all exercises.
    /// </summary>
    /// <response code="200">OK</response>
    [HttpGet]
    [Route(Routes.Exercise.Get)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        var result = await _requestSender.Send(new GetExercisesQuery());

        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

    /// <summary>
    /// Get the exercise with the specified ID.
    /// </summary>
    /// <response code="200">OK</response>
    /// <response code="404">Exercise with the given id not found.</response>
    [HttpGet]
    [Route(Routes.Exercise.GetById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(string id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update the exercise with the specified ID.
    /// </summary>
    [HttpPut]
    [Route(Routes.Exercise.Update)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateExerciseRequest request)
    {
        // One or two slides: flow
        // One slide: OpenAPI (Swagger) documentation from endpoints
        // Create request contracts in API layer
        // Map incoming request to Exercise domain object
        // Pass domain object to repository
        // Repository handles data access
        // Return exercise response defined in API layer contract
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete the exercise with the specified ID.
    /// </summary>
    /// <response code="204">The exercise has been deleted.</response>
    [HttpDelete]
    [Route(Routes.Exercise.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(string id)
    {
        throw new NotImplementedException();
    }
}