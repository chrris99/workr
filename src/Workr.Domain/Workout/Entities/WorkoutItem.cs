using Workr.Core;
using Workr.Domain.Workout.ValueObjects;

namespace Workr.Domain.Workout.Entities;

public sealed class WorkoutItem : Entity<WorkoutItemId>
{
    public WorkoutItem(WorkoutItemId id) : base(id)
    {
    }
}