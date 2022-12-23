import { Component, OnInit } from '@angular/core';
import { Dialog } from '@angular/cdk/dialog';

import { Exercise } from '../../models/exercise';
import { ExerciseService } from '../../services/exercise.service';
import { ExerciseDialogComponent } from '../exercise-dialog/exercise-dialog.component';

@Component({
  selector: 'app-exercise-list',
  templateUrl: './exercise-list.component.html'
})
export class ExerciseListComponent implements OnInit {
  title: string = 'Exercises! 💪';
  description: string = 'All your exercises appear here. You can use these exercises to create workout templates and workouts.';

  exercises: Array<Exercise> = [
    {
      id: '1',
      name: 'Bicep curl',
      description: 'Stand with your feet shoulder-width apart and holding a pair of dumbbells at your sides, palms facing forward. Engage your core and keep your chest lifted as you bend your elbows and lift the dumbbells up toward your shoulders. Lower the dumbbells back down to the starting position, and repeat for the desired number of repetitions. You can also do this exercise using a barbell instead of dumbbells, if you prefer.',
      type: 'Weighted',
      muscleGroups: ['Biceps'],
      icon: 'https://clipartix.com/wp-content/uploads/2016/12/Workout-free-exercise-clip-art-pictures-clipartix.jpg'
    },
    {
      id: '2',
      name: 'Bench press',
      description: 'Lie on a flat bench with your feet firmly planted on the ground. Grasp the barbell with an overhand grip and lift it off the rack. Lower the barbell to your chest, keeping your elbows close to your sides. Push the barbell back up to the starting position and repeat for the desired number of repetitions. Keep your back flat on the bench and avoid arching your back or bouncing the weight off your chest.',
      type: 'Weighted',
      muscleGroups: ['Chest', 'Triceps'],
      icon: 'https://clipartix.com/wp-content/uploads/2016/12/Workout-free-exercise-clip-art-pictures-clipartix.jpg'
    },
    {
      id: '3',
      name: 'Pull up',
      description: 'Grab a pull-up bar with an overhand grip (palms facing away from you) that is slightly wider than shoulder-width apart. Hang from the bar with your arms fully extended and your feet off the ground. Pull your chest up to the bar by squeezing your shoulder blades together and pulling your elbows down to your sides. Lower yourself back to the starting position and repeat for the desired number of repetitions. Avoid swinging or kipping and focus on using your back and arm muscles to lift your body.',
      type: 'Bodyweight',
      muscleGroups: ['Back', 'Biceps'],
      icon: 'https://clipartix.com/wp-content/uploads/2016/05/Exercise-free-clip-art-people-exercising-free-vector-for-free.png'
    },
    {
      id: '4',
      name: 'Barbell squats',
      description: 'Stand with your feet shoulder-width apart and hold a barbell across your upper back, just below your shoulders. Bend your knees and lower your hips down and back as if you are sitting back into a chair. Continue lowering yourself until your thighs are parallel to the ground or your hips are slightly below parallel. Pause for a moment, then push through your heels to return to the starting position. Repeat the movement for the desired number of repetitions. Keep your chest up, avoid rounding your back, and use a full range of motion.',
      type: 'Weighted',
      muscleGroups: ['Quadriceps', 'Hamstrings', 'Glutes'],
      icon: 'https://clipartix.com/wp-content/uploads/2016/12/Workout-free-exercise-clip-art-pictures-clipartix.jpg'
    },
  ]

  constructor(private exerciseService: ExerciseService, private dialog: Dialog) { }

  ngOnInit(): void {
    this.exerciseService.getAll().subscribe({
      next: (res) => this.exercises = res.body ?? []
    });
  }

  public openExerciseDialog(): void {
    const dialogRef = this.dialog.open(ExerciseDialogComponent, {
      width: "500px",
      data: {
        title: "hello"
      }
    });

    dialogRef.closed.subscribe((result: any) => {
      console.log(result);
    })
  }
}
