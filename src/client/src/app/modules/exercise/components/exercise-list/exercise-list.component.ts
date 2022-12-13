import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

import { Exercise } from '../../models/exercise';
import { ExerciseService } from '../../services/exercise.service';
import { ExerciseDialogComponent } from '../exercise-dialog/exercise-dialog.component';

@Component({
  selector: 'app-exercise-list',
  templateUrl: './exercise-list.component.html'
})
export class ExerciseListComponent implements OnInit {
  exercises: Array<Exercise> = new Array<Exercise>();

  constructor(private exerciseService: ExerciseService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.exerciseService.getAll().subscribe({
      next: (res) => this.exercises = res.body ?? []
    });
  }

  public openExerciseDialog(): void {
    const dialogRef = this.dialog.open(ExerciseDialogComponent, {
      data: {

      }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(result);
    })
  }
}
