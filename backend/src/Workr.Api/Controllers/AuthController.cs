using Microsoft.AspNetCore.Mvc;
using Workr.Api.Contracts.Auth;
using Workr.Application.Abstractions;
using Workr.Application.Services;
using Workr.Domain.Abstractions;

namespace Workr.Api.Controllers;

/// <summary>
/// Controller for authenticating users.
/// </summary>
[ApiController]
[Produces("application/json")]
public sealed class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly ITokenProvider _tokenProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthController"/> class.
    /// </summary>
    /// <param name="authService"></param>
    /// <param name="tokenProvider"></param>
    public AuthController(IAuthService authService, ITokenProvider tokenProvider)
    {
        _authService = authService;
        _tokenProvider = tokenProvider;
    }
    
    /// <summary>
    /// Create and register a user to the database.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/auth/register
    ///     {
    ///        "email": "john.doe@gmail.com",
    ///        "name": "John Doe",
    ///        "password": "super-secure-password"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">User registered successfully</response>
    /// <response code="400">Can't create user with given parameters</response>
    [HttpPost]
    [Route(Routes.Auth.Register)]
    [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var createResult = await _authService.RegisterAsync(request.Email, request.Name, request.Password);
        
        if (createResult.IsFailure)
            return BadRequest(createResult.Error);

        var user = createResult.Value;

        var token = _tokenProvider.Create(user);

        return Ok(new AuthResponse
        {
            Email = user.Email,
            Name = user.Name,
            Token = token
        });
    }

    /// <summary>
    /// Authenticate a registered user.
    /// </summary>
    [HttpPost]
    [Route(Routes.Auth.Login)]
    [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var loginResult = await _authService.LoginAsync(request.Email, request.Password);
        
        if (loginResult.IsFailure)
            return BadRequest(loginResult.Error);

        var user = loginResult.Value;

        var token = _tokenProvider.Create(user);
        
        return Ok(new AuthResponse
        {
            Email = user.Email,
            Name = user.Name,
            Token = token
        });
    }
}