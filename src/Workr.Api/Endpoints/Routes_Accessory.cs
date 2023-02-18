namespace Workr.Api.Endpoints;

public static partial class Routes
{
    private const string AccessoryBaseUri = $"{Root}/accessory";

    /// <summary>
    /// Define API endpoints for the <see cref="Accessory"/> resource.
    /// </summary>
    public static class Accessory
    {
        public const string Create = AccessoryBaseUri;
        public const string Get = AccessoryBaseUri;
        public const string Update = AccessoryBaseUri + "/{id}";
        public const string Delete = AccessoryBaseUri + "/{id}";
    }
}