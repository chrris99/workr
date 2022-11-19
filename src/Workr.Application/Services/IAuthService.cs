using Workr.Application.Contracts.Auth;
using Workr.Domain.Abstractions;

namespace Workr.Application.Services;

public interface IAuthService
{
    Task<Result<TokenResponse>> RegisterAsync(string email, string password);
}