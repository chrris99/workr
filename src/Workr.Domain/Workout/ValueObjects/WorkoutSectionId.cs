using Workr.Core;

namespace Workr.Domain.Workout.ValueObjects;

public sealed class WorkoutSectionId : ValueObject
{
    public Guid Value { get; set; }

    private WorkoutSectionId(Guid value) => Value = value;

    public static WorkoutSectionId CreateUnique() => new(Guid.NewGuid());

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}