using Workr.Domain.Entities;

namespace Workr.Application.Abstractions;

/// <summary>
/// Authentication token provider interface.
/// </summary>
public interface ITokenProvider
{
    /// <summary>
    /// Creates the authentication token for the specified user.
    /// </summary>
    /// <param name="user">The user.</param>
    /// <returns>The authentication token for the specified user.</returns>
    string Create(User user);
}