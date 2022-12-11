using System.ComponentModel.DataAnnotations;

namespace Workr.Api.Contracts.Auth;

public record RegisterRequest
{
    /// <summary>
    ///
    /// </summary>
    /// <example>john.doe@email.com</example>
    [Required]
    public string Email { get; init; }
    
    /// <example>John Doe</example>
    public string Name { get; init; }
    
    /// <example>Dummy password</example>
    [Required]
    public string Password { get; init; }
}