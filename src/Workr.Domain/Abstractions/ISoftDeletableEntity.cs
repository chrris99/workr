﻿namespace Workr.Domain.Abstractions;

public interface ISoftDeletableEntity
{
    DateTime? DeletedOnUtc { get; }
    bool Deleted { get; }
}