namespace Workr.Api;

public static class Routes
{
    private const string Root = "api";

    public static class Auth
    {
        public const string Base = $"{Root}/auth";
        
        public const string Register = "register";
        public const string Login = "login";
    }
    
    public static class Exercise
    {
        public const string Base = $"{Root}/exercise";
        
        public const string Create = "";
        public const string Update = "";
        public const string Delete = "";
    }
}