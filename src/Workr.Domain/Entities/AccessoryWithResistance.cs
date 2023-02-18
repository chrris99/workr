using Workr.Domain.ValueObjects;

namespace Workr.Domain.Entities;

public sealed class AccessoryWithResistance : Accessory
{
    public Resistance Resistance { get; set; }
}