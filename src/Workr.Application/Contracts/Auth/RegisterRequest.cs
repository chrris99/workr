﻿namespace Workr.Application.Contracts.Auth;

public sealed class RegisterRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}