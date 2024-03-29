﻿using Workr.Core;

namespace Workr.Domain.Entities;

public class Accessory : Entity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Accessory() { }
    public Accessory(Guid? id = default) : base(id) { }
}