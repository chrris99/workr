using Marten;
using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;
using Workr.Domain.Errors;

namespace Workr.Application.Queries;

public sealed class GetExerciseByIdQueryHandler : IQueryHandler<GetExerciseByIdQuery, Result<Exercise>>
{
    private readonly IQuerySession _session;

    public GetExerciseByIdQueryHandler(IQuerySession session) => _session = session;

    public async Task<Result<Exercise>> Handle(GetExerciseByIdQuery request, CancellationToken cancellationToken)
    {
        var exercise = await _session.LoadAsync<Exercise>(Guid.Parse(request.ExerciseId), cancellationToken);

        return exercise ?? Result.Failure<Exercise>(DomainErrors.Exercise.NotFoundById);
    }
}