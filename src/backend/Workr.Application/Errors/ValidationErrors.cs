using Workr.Domain.Abstractions;

namespace Workr.Application.Errors;

internal static class ValidationErrors
{
    /// <summary>
    /// Contains the create user validation errors.
    /// </summary>
    internal static class CreateUser
    {
        internal static Error EmailIsRequired => new ("CreateUser.EmailIsRequired", "The email is required.");

        internal static Error PasswordIsRequired => new ("CreateUser.PasswordIsRequired", "The password is required.");
    }
}