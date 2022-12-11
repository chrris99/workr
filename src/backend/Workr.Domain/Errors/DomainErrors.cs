using Workr.Domain.Abstractions;

namespace Workr.Domain.Errors;

/// <summary>
/// Contains the domain errors.
/// </summary>
public static class DomainErrors
{
    public static class User
    {
        private static readonly string _base = nameof(User);
        
        public static Error AlreadyExists =>
            new ($"{_base}.AlreadyExists", "User with the given email address already exists.");
    }
}