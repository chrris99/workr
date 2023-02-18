using Workr.Domain.Entities;

namespace Workr.Contracts.Exercise;

public sealed record ExerciseResponse(
    Guid Id,
    string Name,
    string? Description,
    string Type,
    IEnumerable<Domain.Entities.Accessory>? RequiredAccessories,
    IEnumerable<string>? TargetMuscleGroups);