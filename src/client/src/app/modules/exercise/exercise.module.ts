import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/shared/shared.module';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ExerciseRoutingModule } from './exercise-routing.module';
import { ExerciseListComponent } from './components/exercise-list/exercise-list.component';
import { ExerciseCardComponent } from './components/exercise-card/exercise-card.component';
import { ExerciseDetailComponent } from './components/exercise-detail/exercise-detail.component';
import { ExerciseDialogComponent } from './components/exercise-dialog/exercise-dialog.component';

@NgModule({
  declarations: [
    ExerciseCardComponent,
    ExerciseDetailComponent,
    ExerciseListComponent,
    ExerciseDialogComponent
  ],
  imports: [
    CommonModule,
    ExerciseRoutingModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    SharedModule
  ],
  exports: [
    ExerciseListComponent
  ]
})
export class ExerciseModule { }
