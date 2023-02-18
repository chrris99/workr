namespace Workr.Contracts.AccessoryContracts;

public sealed record CreateAccessoryRequest(
    string Name,
    string? Description);