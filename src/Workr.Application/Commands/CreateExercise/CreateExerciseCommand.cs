using Workr.Core;
using Workr.Core.Mediator;
using Workr.Domain.Entities;

namespace Workr.Application.Commands.CreateExercise;

public record CreateExerciseCommand(
    string Name,
    string? Description,
    string Type,
    IEnumerable<Accessory>? RequiredAccessories,
    IEnumerable<string>? TargetMuscleGroups) : ICommand<Result>;