using Workr.Core;
using Workr.Domain.Entities;

namespace Workr.Application.Services;

public interface IAuthService
{
    Task<Result<User>> RegisterAsync(string email, string name, string password);
    Task<Result<User>> LoginAsync(string email, string password);
}