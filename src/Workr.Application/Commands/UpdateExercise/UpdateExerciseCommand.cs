using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Commands.UpdateExercise;

public sealed record UpdateExerciseCommand(
    string Id,
    string Name,
    string? Description,
    string Type,
    IEnumerable<Accessory>? RequiredAccessories,
    IEnumerable<string>? TargetMuscleGroups) : ICommand<Result>;