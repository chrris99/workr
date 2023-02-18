using Workr.Core;

namespace Workr.Domain.Errors;

public static partial class DomainErrors
{
    private const string ExerciseBase = nameof(Exercise);

    public static class Exercise
    {
        public static Error NotFoundById =>
            new($"{ExerciseBase}.NotFoundById", "Exercise with given ID not found in database");
    }
}