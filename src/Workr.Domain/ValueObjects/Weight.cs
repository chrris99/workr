using Workr.Core;

namespace Workr.Domain.ValueObjects;

public sealed class Weight : ValueObject
{
    public double Value { get; }

    public Weight(double value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetValues()
    {
        yield return Value;
    }
}