using System.Web.Http;

namespace Workr.Api.Controllers;

[Route("/api/[controller]")]
public sealed class ExerciseController : ApiController
{
    [HttpGet]
    public IResult GetExercise()
    {
        return Results.Ok("Ping");
    }
}