using Marten;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Queries;

public sealed class GetExercisesQueryHandler : IQueryHandler<GetExercisesQuery, Result<IReadOnlyList<Exercise>>>
{
    private readonly ILogger<GetExercisesQueryHandler> _logger;
    private readonly IQuerySession _session;

    public GetExercisesQueryHandler(ILogger<GetExercisesQueryHandler> logger, IQuerySession session)
        => (_logger, _session) = (logger, session);

    public async Task<Result<IReadOnlyList<Exercise>>> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
    {
        var exercises = await _session
            .Query<Exercise>()
            .ToListAsync(cancellationToken);

        return exercises.ToList();
    }
}