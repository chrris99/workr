import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DialogModule } from '@angular/cdk/dialog';
import { SharedModule } from 'src/app/shared/shared.module';

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
    DialogModule,
    SharedModule
  ],
  exports: [
    ExerciseListComponent
  ]
})
export class ExerciseModule { }
