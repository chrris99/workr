namespace Workr.Api.Endpoints;

public static partial class Routes
{
    private const string AuthBaseUri = $"{Root}/auth";

    /// <summary>
    /// Define API endpoints for authentication.
    /// </summary>
    public static class Auth
    {
        public const string Register = AuthBaseUri + "/register";
        public const string Login = AuthBaseUri + "/login";
    }
}