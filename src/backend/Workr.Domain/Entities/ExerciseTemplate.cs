using Workr.Domain.Abstractions;

namespace Workr.Domain.Entities;

public sealed class ExerciseTemplate : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Category { get; set; }
    
    public IEnumerable<Accessory>? RequiredAccessories { get; set; }

    public ExerciseTemplate(Guid id) : base(id) { }
}