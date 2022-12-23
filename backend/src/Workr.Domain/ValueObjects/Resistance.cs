using Workr.Domain.Abstractions;

namespace Workr.Domain.ValueObjects;

public class Resistance : ValueObject
{
    public int Value { get; }

    public Resistance(int value)
    {
        Value = value;
    }
    
    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}