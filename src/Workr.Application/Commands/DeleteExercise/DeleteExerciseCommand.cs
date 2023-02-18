using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Commands.DeleteExercise;

public sealed record DeleteExerciseCommand(string ExerciseId) : ICommand<Result>;