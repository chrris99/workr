using Workr.Core;

namespace Workr.Domain.Workout.ValueObjects;

public sealed class WorkoutBlockId : ValueObject
{
    public Guid Value { get; }

    private WorkoutBlockId(Guid value) => Value = value;

    public static WorkoutBlockId CreateUnique() => new(Guid.NewGuid());

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}