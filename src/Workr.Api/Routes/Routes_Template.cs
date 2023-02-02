namespace Workr.Api;

public static partial class Routes
{
    private const string TemplateBaseUri = $"{Root}/template";
    
    /// <summary>
    /// Define API endpoints for <see cref=""/> resources.
    /// </summary>
    public static class Template
    {
        public const string Create = TemplateBaseUri;
        public const string Get = TemplateBaseUri;
        public const string GetById = TemplateBaseUri + "/{id}";
        public const string Update = TemplateBaseUri + "/{id}";
        public const string Delete = TemplateBaseUri + "/{id}";
    }
}