﻿using Microsoft.AspNetCore.Mvc;
using Workr.Api.Contracts.Auth;
using Workr.Api.Endpoints;
using Workr.Core;

namespace Workr.Api.Controllers;

/// <summary>
/// Controller for authenticating users.
/// </summary>
[ApiController]
[Produces("application/json")]
public sealed class AuthController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthController"/> class.
    /// </summary>
    public AuthController()
    {

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}