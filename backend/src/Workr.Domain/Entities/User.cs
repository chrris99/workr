using Microsoft.AspNetCore.Identity;

namespace Workr.Domain.Entities;

public class User : IdentityUser
{
    public string Name { get; set; }

    public void CreateExercise(Exercise exercise)
    {
        throw new NotImplementedException();
    }

    public void CreateWorkout(Workout workout)
    {
        throw new NotImplementedException();
    }

    public void StartWorkout(string workoutId)
    {
        throw new NotImplementedException();
    }
}