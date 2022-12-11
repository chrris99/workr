import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExerciseRoutingModule } from './exercise-routing.module';
import { ExerciseListComponent } from './components/exercise-list/exercise-list.component';
import { ExerciseCardComponent } from './components/exercise-card/exercise-card.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ExerciseDetailComponent } from './components/exercise-detail/exercise-detail.component';

@NgModule({
  declarations: [
    ExerciseCardComponent,
    ExerciseDetailComponent,
    ExerciseListComponent
  ],
  imports: [
    CommonModule,
    ExerciseRoutingModule,
    SharedModule
  ],
  exports: [
    ExerciseListComponent
  ]
})
export class ExerciseModule { }
