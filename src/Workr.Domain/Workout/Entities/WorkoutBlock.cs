using Workr.Core;
using Workr.Domain.Workout.ValueObjects;

namespace Workr.Domain.Workout.Entities;

public sealed class WorkoutBlock : Entity<WorkoutBlockId>
{
    public WorkoutBlock(WorkoutBlockId id) : base(id)
    {
    }
}