import { Component, Inject } from '@angular/core';
import {Dialog, DialogRef, DIALOG_DATA} from '@angular/cdk/dialog';

import { Exercise } from '../../models/exercise';

export interface ExerciseDialogDiata {
  title: string;
  exercise: Exercise;
}

@Component({
  selector: 'app-exercise-dialog',
  templateUrl: './exercise-dialog.component.html'
})
export class ExerciseDialogComponent {
  constructor(
    public dialogRef: DialogRef<string>,
    @Inject(DIALOG_DATA) public data: ExerciseDialogDiata,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
