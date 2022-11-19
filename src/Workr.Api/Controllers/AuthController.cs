using Microsoft.AspNetCore.Mvc;
using Workr.Application.Contracts.Auth;
using Workr.Application.Services;

namespace Workr.Api.Controllers;

[ApiController]
[Route(Routes.Auth.Base)]
public sealed class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthController"/> class.
    /// </summary>
    /// <param name="authService"></param>
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    
    [HttpPost]
    [Route(Routes.Auth.Register)]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid) return BadRequest();

        var result = await _authService.RegisterAsync(request.Email, request.Password);

        return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
    }

    [HttpPost]
    [Route(Routes.Auth.Login)]
    public async Task<IActionResult> Login()
    {
        if (!ModelState.IsValid) return BadRequest();
        
        // Model state is valid, implement logic
        return Ok();
    }
}