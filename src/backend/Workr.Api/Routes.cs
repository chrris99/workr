namespace Workr.Api;

public static class Routes
{
    private const string Root = "api";

    public static class Auth
    {
        private const string Base = $"{Root}/auth";
        
        public const string Register = Base + "/register";
        public const string Login = Base + "/login";
    }
    
    public static class Exercise
    {
        private const string Base = $"{Root}/exercise";

        public const string GetAll = Base;
        public const string GetById = Base + "/{exerciseId}";
        public const string Create = "exercise";
        public const string Update = Base + "/{exerciseId}";
        public const string Delete = Base + "/{exerciseId}";
    }

    public static class Workout
    {
        
    }

    public static class Equipment
    {
        
    }
}