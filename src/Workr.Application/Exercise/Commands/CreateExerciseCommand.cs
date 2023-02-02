using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Exercise.Commands;

public record CreateExerciseCommand(
    string Name,
    string? Description,
    string Type) : ICommand<Result>;