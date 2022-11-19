using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Workr.Application.Abstractions;
using Workr.Application.Contracts.Auth;
using Workr.Domain.Abstractions;
using Workr.Domain.Entities;
using Workr.Domain.Errors;

namespace Workr.Application.Services;

public sealed class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtProvider _jwtProvider;

    public AuthService(UserManager<User> userManager, IJwtProvider jwtProvider)
    {
        _userManager = userManager;
        _jwtProvider = jwtProvider;
    }
    
    public async Task<Result<TokenResponse>> RegisterAsync(string email, string password)
    {
        if (await _userManager.FindByEmailAsync(email) != null)
            return Result.Failure<TokenResponse>(DomainErrors.UserAlreadyExists);
        
        var user = new User
        {
            Email = email,
            UserName = email
        };

        var createdUser = await _userManager.CreateAsync(user, password);

        return new TokenResponse(_jwtProvider.Create(user));
    }
}