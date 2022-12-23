using Workr.Domain.Abstractions;

namespace Workr.Domain.Errors;

public static partial class DomainErrors
{
    private const string UserBase = nameof(User);
    
    public static class User
    {
        public static Error CreateFailed =>
            new($"{UserBase}.CreateFailed", "Unknown error occured when creating a new user.");

        public static Error NotFoundById =>
            new($"{UserBase}.NotFoundById", "User with given ID not found in database.");

        public static Error NotFoundByEmail =>
            new($"{UserBase}.NotFoundByEmail", "User with given email not found in database.");

        public static Error NotFoundByName =>
            new($"{UserBase}.NotFoundByName", "User with given name not found in database");

        public static Error DuplicateEmail =>
            new($"{UserBase}.DuplicateEmail", "Email already in use. Try signing in instead.");

        public static Error IncorrectPassword =>
            new($"{UserBase}.IncorrectPassword", "The provided password is incorrect.");
    }
}