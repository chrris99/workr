using Workr.Core;
using Workr.Domain.ValueObjects;

namespace Workr.Domain.Entities;

public class Feedback : Entity
{
    public Rating Effort { get; set; } = new (0);
    public string? Comment { get; set; }

    public Feedback(Guid id) : base(id)
    {
    }
}