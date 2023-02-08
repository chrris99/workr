using Marten;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Commands.CreateExercise;

public sealed class CreateExerciseCommandHandler : ICommandHandler<CreateExerciseCommand, Result>
{
    private readonly ILogger<CreateExerciseCommandHandler> _logger;
    private readonly IDocumentSession _session;

    public CreateExerciseCommandHandler(ILogger<CreateExerciseCommandHandler> logger, IDocumentSession session)
    {
        _logger = logger;
        _session = session;
    }

    public async Task<Result> Handle(CreateExerciseCommand command, CancellationToken cancellationToken)
    {
        var exercise = new Exercise
        {
            Name = command.Name,
            Description = command.Description,
            Type = command.Type,
            RequiredAccessories = command.RequiredAccessories,
            TargetMuscleGroups = command.TargetMuscleGroups
        };

        _session.Store(exercise);

        await _session.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}