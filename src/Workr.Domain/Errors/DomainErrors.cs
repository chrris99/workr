using Workr.Core;

namespace Workr.Domain.Errors;

/// <summary>
/// Contains the domain errors.
/// </summary>
public static partial class DomainErrors
{
    public static class General
    {
        public static Error ServerError => new Error("General.ServerError", "An unknown server error occured");
    }
}