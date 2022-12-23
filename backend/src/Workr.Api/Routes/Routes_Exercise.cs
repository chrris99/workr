namespace Workr.Api;

public static partial class Routes
{
    private const string ExerciseBaseUri = $"{Root}/exercise";
    
    /// <summary>
    /// Define API endpoints for the <see cref="Exercise"/> resource.
    /// </summary>
    public static class Exercise
    {
        public const string Create = ExerciseBaseUri;
        public const string Get = ExerciseBaseUri;
        public const string GetById = ExerciseBaseUri + "/{id}";
        public const string Update = ExerciseBaseUri + "/{id}";
        public const string Delete = ExerciseBaseUri + "/{id}";
    }
}