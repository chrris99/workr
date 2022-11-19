namespace Workr.Infrastructure.Auth;

/// <summary>
/// Represents the JWT configuration settings.
/// </summary>
public sealed class JwtOptions
{
    public const string Jwt = "Jwt";

    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Secret { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JwtOptions"/> class.
    /// </summary>
    public JwtOptions()
    {
        Issuer = string.Empty;
        Audience = string.Empty;
        Secret = string.Empty;
    }
}