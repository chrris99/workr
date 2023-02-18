namespace Workr.Core;

/// <summary>
/// Abstract base class for entities.
/// </summary>
public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Entity{TId}"/> class.
    /// </summary>
    /// <param name="id">The entity identifier.</param>
    protected Entity(TId id)
        => Id = id;

    /// <summary>
    /// Gets the entity identifier.
    /// </summary>
    private TId Id { get; }

    public static bool operator ==(Entity<TId> left, Entity<TId> right)
        => Equals(left, right);

    public static bool operator !=(Entity<TId> left, Entity<TId> right)
        => !Equals(left, right);

    /// <inheritdoc />
    public bool Equals(Entity<TId>? other)
        => Equals((object?)other);

    /// <inheritdoc />
    public override bool Equals(object? obj)
        => obj is Entity<TId> entity && Id.Equals(entity.Id);

    /// <inheritdoc />
    public override int GetHashCode()
        => Id.GetHashCode();
}