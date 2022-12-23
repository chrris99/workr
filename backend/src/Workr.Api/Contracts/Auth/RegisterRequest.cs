using System.ComponentModel.DataAnnotations;

namespace Workr.Api.Contracts.Auth;

/// <summary>
/// User registration request.
/// </summary>
public record RegisterRequest
{
    /// <summary>
    /// Email summary.
    /// </summary>
    /// <example>john.doe@email.com</example>
    [Required]
    public string Email { get; init; }
    
    /// <example>John Doe</example>
    public string? Name { get; init; }
    
    /// <example>Dummy password</example>
    [Required]
    public string Password { get; init; }
}