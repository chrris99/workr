using Workr.Core;

namespace Workr.Domain.Entities;

public class WorkoutTemplate : Entity
{
    // Only used for creating actual workouts (a workout can be completed or planned)

    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public IEnumerable<Exercise>? Exercises { get; set; }

    public WorkoutTemplate(Guid id) : base(id) { }
}