namespace Workr.Api.Contracts.Auth;

public record AuthResponse
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Token { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthResponse"/> record.
    /// </summary>
    public AuthResponse()
    {
        Email = string.Empty;
        Name = string.Empty;
        Token = string.Empty;
    }
}