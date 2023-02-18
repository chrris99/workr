using Workr.Core;
using Workr.Domain.Workout.ValueObjects;

namespace Workr.Domain.Workout.Entities;

public sealed class WorkoutSection : Entity<WorkoutSectionId>
{
    public WorkoutSection(WorkoutSectionId id) : base(id)
    {
    }
}