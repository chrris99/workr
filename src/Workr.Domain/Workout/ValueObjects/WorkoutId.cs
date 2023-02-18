using Workr.Core;

namespace Workr.Domain.Workout.ValueObjects;

public sealed class WorkoutId : ValueObject
{
    public Guid Value { get; }

    private WorkoutId(Guid value) => Value = value;

    public static WorkoutId CreateUnique() => new(Guid.NewGuid());

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}