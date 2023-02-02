using System.ComponentModel.DataAnnotations;

namespace Workr.Api.Contracts.Exercise;

public record CreateExerciseRequest
{
    /// <example>Bench press</example>
    [Required]
    public string Name { get; init; }
    
    /// <example>Lie down on a flat bench with your feet on the floor and your back straight. Grasp the barbell or dumbbells with an overhand grip, slightly wider than shoulder-width apart. Lower the weight slowly towards your chest, keeping your elbows close to your body, then pause and push the weight back up to the starting position.</example>
    public string? Description { get; init; }
    
    /// <example>weighted</example>
    [Required]
    public string Type { get; init; }
}