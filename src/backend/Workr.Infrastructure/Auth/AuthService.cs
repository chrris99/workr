using Microsoft.AspNetCore.Identity;
using Workr.Application.Services;
using Workr.Domain.Abstractions;
using Workr.Domain.Entities;
using Workr.Domain.Errors;

namespace Workr.Infrastructure.Auth;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    
    public AuthService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }
    
    public async Task<Result<User>> RegisterAsync(string email, string name, string password)
    {
        var userName = string.IsNullOrWhiteSpace(name) ? email : name;
        
        var user = new User
        {
            Email = email,
            Name = name,
            UserName = email
        };

        var result = await _userManager.CreateAsync(user, password);

        var error = result.Errors.FirstOrDefault(e => e.Code.EndsWith(DomainErrors.User.DuplicateEmail.Message)) != null
            ? DomainErrors.User.DuplicateEmail
            : DomainErrors.User.CreateFailed;
        
        return result.Succeeded
            ? user
            : Result.Failure<User>(error);
    }

    public async Task<Result<User>> LoginAsync(string email, string password)
    {
        var getUserResult = await GetByEmailAsync(email);

        if (getUserResult.IsFailure)
            return Result.Failure<User>(getUserResult.Error);

        var user = getUserResult.Value;

        var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, password);

        return isPasswordCorrect
            ? user
            : Result.Failure<User>(DomainErrors.User.IncorrectPassword);
    }

    private async Task<Result<User>> GetByEmailAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        return user ?? Result.Failure<User>(DomainErrors.User.NotFoundByEmail);
    }
}