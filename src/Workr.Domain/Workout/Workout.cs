using Workr.Core;
using Workr.Domain.Workout.Entities;
using Workr.Domain.Workout.ValueObjects;

namespace Workr.Domain.Workout;

public class Workout : AggregateRoot<WorkoutId>
{
    private readonly List<WorkoutSection> _sections;

    public Workout(WorkoutId id) : base(id)
    {
    }
}