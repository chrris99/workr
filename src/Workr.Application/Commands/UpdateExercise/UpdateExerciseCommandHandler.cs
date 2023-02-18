using Marten;
using Marten.Exceptions;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;
using Workr.Domain.Errors;

namespace Workr.Application.Commands.UpdateExercise;

public sealed class UpdateExerciseCommandHandler : ICommandHandler<UpdateExerciseCommand, Result>
{
    private ILogger<UpdateExerciseCommandHandler> _logger;
    private IDocumentSession _session;

    public UpdateExerciseCommandHandler(ILogger<UpdateExerciseCommandHandler> logger, IDocumentSession session)
        => (_logger, _session) = (logger, session);

    public async Task<Result> Handle(UpdateExerciseCommand request, CancellationToken cancellationToken)
    {
        var exercise = new Exercise(new Guid(request.Id))
        {
            Name = request.Name,
            Description = request.Description,
            Type = request.Type,
            RequiredAccessories = request.RequiredAccessories,
            TargetMuscleGroups = request.TargetMuscleGroups
        };

        try
        {
            _session.Update(exercise);
            await _session.SaveChangesAsync(cancellationToken);
        }
        catch (NonExistentDocumentException e)
        {
            return Result.Failure(DomainErrors.Exercise.NotFoundById);
        }

        return Result.Success();
    }
}