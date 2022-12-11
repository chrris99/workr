using Workr.Domain.Abstractions;

namespace Workr.Domain.Entities;

public class Accessory : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    
    public Accessory(Guid id) : base(id) { }
}