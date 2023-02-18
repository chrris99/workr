using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Queries;

public sealed record GetExerciseByIdQuery(string ExerciseId) : IQuery<Result<Exercise>>;