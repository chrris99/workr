namespace Workr.Application.Contracts.Auth;

public sealed class TokenResponse
{
    public string Token { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TokenResponse"/> class.
    /// </summary>
    /// <param name="token">The token value.</param>
    public TokenResponse(string token) => Token = token;
}