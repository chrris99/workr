using Workr.Domain.ValueObjects;

namespace Workr.Domain.Entities;

public sealed class AccessoryWithWeight : Accessory
{
    public Weight Weight { get; set; }
}