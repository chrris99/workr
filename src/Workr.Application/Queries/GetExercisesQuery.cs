using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Queries;

public sealed record GetExercisesQuery() : IQuery<Result<IReadOnlyList<Exercise>>>;