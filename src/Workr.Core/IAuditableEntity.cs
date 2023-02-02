namespace Workr.Core;
public interface IAuditableEntity
{
    string CreatedBy { get; }
    DateTime CreatedOnUtc { get; }
    DateTime? ModifiedOnUtc { get; }
}