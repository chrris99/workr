using Workr.Domain.Entities;

namespace Workr.Api.Contracts.Exercise;

public sealed record UpdateExerciseRequest(
    string Name,
    string? Description,
    string Type,
    IEnumerable<Accessory>? RequiredAccessories,
    IEnumerable<string>? TargetMuscleGroups);