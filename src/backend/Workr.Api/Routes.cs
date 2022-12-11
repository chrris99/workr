namespace Workr.Api;

public static class Routes
{
    private const string Root = "api";

    public static class Auth
    {
        public const string Base = $"{Root}/auth";
        
        public const string Register = "auth/register";
        public const string Login = "auth/login";
    }
    
    public static class Exercise
    {
        public const string Base = $"{Root}/exercise";

        public const string GetAll = "exercise";
        public const string GetById = "exercise/{exerciseId}";
        public const string Create = "exercise";
        public const string Update = "exercise/{exerciseId}";
        public const string Delete = "exercise/{exerciseId}";
    }

    public static class Workout
    {
        
    }

    public static class Equipment
    {
        
    }
}