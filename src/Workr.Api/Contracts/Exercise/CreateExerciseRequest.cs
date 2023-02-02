using Workr.Domain.Entities;

namespace Workr.Api.Contracts.Exercise;

public sealed record CreateExerciseRequest(
    string Name,
    string? Description,
    string Type,
    IEnumerable<Accessory>? RequiredAccessories,
    IEnumerable<string>? TargetMuscleGroups);