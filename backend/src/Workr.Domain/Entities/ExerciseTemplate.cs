using Workr.Core;

namespace Workr.Domain.Entities;

public sealed class ExerciseTemplate : Entity, IAuditableEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Category { get; set; }

    public IEnumerable<Accessory>? RequiredAccessories { get; set; }

    public string CreatedBy { get; }
    public DateTime CreatedOnUtc { get; }
    public DateTime ModifiedOnUtc { get; }

    public ExerciseTemplate(Guid id) : base(id) { }
}