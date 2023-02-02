using Workr.Core;

namespace Workr.Domain.Entities;

public sealed class Exercise : Entity, IAuditableEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Type { get; set; }
    public IEnumerable<Accessory>? RequiredAccessories { get; set; }
    public IEnumerable<string>? TargetMuscleGroups { get; set; }

    public string CreatedBy { get; }
    public DateTime CreatedOnUtc { get; }
    public DateTime? ModifiedOnUtc { get; }

    public Exercise(Guid id) : base(id) { }
}