namespace Workr.Api;

public static partial class Routes
{
    private const string WorkoutBaseUri = $"{Root}/workout";
    
    /// <summary>
    /// Define API endpoints for the <see cref="Workout"/> resource.
    /// </summary>
    public static class Workout
    {
        public const string Create = WorkoutBaseUri;        
        public const string Get = WorkoutBaseUri;
        public const string GetById = WorkoutBaseUri + "/{id}";
        public const string Update = WorkoutBaseUri + "/{id}";
        public const string Delete = WorkoutBaseUri + "/{id}";
    }
}