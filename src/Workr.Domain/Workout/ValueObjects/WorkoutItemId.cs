using Workr.Core;

namespace Workr.Domain.Workout.ValueObjects;

public sealed class WorkoutItemId : ValueObject
{
    public Guid Value { get; }

    private WorkoutItemId(Guid value) => Value = value;

    public static WorkoutItemId CreateUnique() => new(Guid.NewGuid());

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}