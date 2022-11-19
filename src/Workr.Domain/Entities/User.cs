using Microsoft.AspNetCore.Identity;

namespace Workr.Domain.Entities;

public class User : IdentityUser
{
    public string Name { get; set; }
}