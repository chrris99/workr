using Workr.Core;
using Workr.Domain.User.ValueObjects;

namespace Workr.Domain.User;

public sealed class User : AggregateRoot<UserId>
{
    public User(UserId id) : base(id)
    {
    }
}