using Workr.Core;

namespace Workr.Domain.User.ValueObjects;

public sealed class UserId : ValueObject
{
    public Guid Value { get; }

    private UserId(Guid value)
    {
        Value = value;
    }

    public static UserId Create()
    {
        return new UserId(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetValues()
    {
        throw new NotImplementedException();
    }
}