using Workr.Domain.Abstractions;

namespace Workr.Domain.Errors;

/// <summary>
/// Contains the domain errors.
/// </summary>
public static class DomainErrors
{
    public static Error UserAlreadyExists =>
        new ("User.AlreadyExists", "User with the given email address already exists.");
}