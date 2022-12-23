namespace Workr.Domain.Abstractions;

public interface IAuditableEntity
{
    string CreatedBy { get; }
    DateTime CreatedOnUtc { get; }
    DateTime ModifiedOnUtc { get; }
}