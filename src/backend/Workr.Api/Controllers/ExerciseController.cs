using Microsoft.AspNetCore.Mvc;
using Workr.Application.Contracts.Exercise;

namespace Workr.Api.Controllers;

[Route(Routes.Exercise.Base)]
public sealed class ExerciseController : ControllerBase
{
    [HttpGet]
    [Route(Routes.Exercise.GetAll)]
    public async Task<IActionResult> GetExercises()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route(Routes.Exercise.GetById)]
    public async Task<IActionResult> GetExerciseById()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [Route(Routes.Exercise.Create)]
    public async Task<IActionResult> CreateExercise([FromBody] CreateExerciseRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route(Routes.Exercise.Update)]
    public async Task<IActionResult> UpdateExercise()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route(Routes.Exercise.Delete)]
    public async Task<IActionResult> DeleteExercise()
    {
        throw new NotImplementedException();
    }
}