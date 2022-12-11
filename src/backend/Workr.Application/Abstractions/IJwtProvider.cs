using Workr.Domain.Entities;

namespace Workr.Application.Abstractions;

/// <summary>
/// JWT Provider interface.
/// </summary>
public interface IJwtProvider
{
    /// <summary>
    /// Creates the JWT for the specified user.
    /// </summary>
    /// <param name="user">The user.</param>
    /// <returns>The JWT for the specified user.</returns>
    string Create(User user);
}