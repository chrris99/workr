using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Workr.Application.Abstractions;
using Workr.Domain.Entities;

namespace Workr.Infrastructure.Auth;

/// <summary>
/// JWT authentication token provider service.
/// </summary>
public sealed class JwtTokenProvider : ITokenProvider
{
    private readonly JwtOptions _options;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="JwtTokenProvider"/> class.
    /// </summary>
    /// <param name="options"></param>
    public JwtTokenProvider(IOptions<JwtOptions> options)
    {
        _options = options.Value;
    }
    
    /// <inheritdoc cref="Create"/>
    public string Create(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Secret));

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = _options.Issuer,
            Audience = _options.Audience,
            Subject = new ClaimsIdentity(new Claim[]
            {
                new ("userId", user.Id),
                new ("email", user.Email)
            }),
            SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
        };
        
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}