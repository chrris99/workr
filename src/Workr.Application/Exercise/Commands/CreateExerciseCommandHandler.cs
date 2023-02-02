using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Exercise.Commands;

public sealed class CreateExerciseCommandHandler : ICommandHandler<CreateExerciseCommand, Result>
{
    private readonly ILogger<CreateExerciseCommandHandler> _logger;

    // Inject repository

    public CreateExerciseCommandHandler(ILogger<CreateExerciseCommandHandler> logger)
    {
        _logger = logger;
    }

    public Task<Result> Handle(CreateExerciseCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling command {command}", "CreateExerciseCommand");

        return Task.FromResult(Result.Success());
    }
}