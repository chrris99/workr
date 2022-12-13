import { Component, Inject, ViewEncapsulation } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

import { Exercise } from '../../models/exercise';

export interface ExerciseDialogDiata {
  title: string;
  exercise: Exercise;
}

@Component({
  selector: 'app-exercise-dialog',
  templateUrl: './exercise-dialog.component.html',
  encapsulation: ViewEncapsulation.None
})
export class ExerciseDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<ExerciseDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ExerciseDialogDiata,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
