using Marten;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Commands.DeleteExercise;

public sealed class DeleteExerciseCommandHandler : ICommandHandler<DeleteExerciseCommand, Result>
{
    private readonly ILogger<DeleteExerciseCommandHandler> _logger;
    private readonly IDocumentSession _session;

    public DeleteExerciseCommandHandler(ILogger<DeleteExerciseCommandHandler> logger, IDocumentSession session)
        => (_logger, _session) = (logger, session);

    public async Task<Result> Handle(DeleteExerciseCommand request, CancellationToken cancellationToken)
    {
        _session.Delete<Exercise>(Guid.Parse(request.ExerciseId));

        await _session.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}