using Workr.Domain.Abstractions;

namespace Workr.Domain.Entities;

public class Workout : Entity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public Workout(Guid id) : base(id) { }
}