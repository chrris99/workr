using Workr.Domain.Abstractions;

namespace Workr.Domain.ValueObjects;

public sealed class Rating : ValueObject
{
    public int Value { get; }
    
    public Rating(int value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}