import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExerciseListComponent } from './components/exercise-list/exercise-list.component';

const routes: Routes = [
  { path: '', component: ExerciseListComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class ExerciseRoutingModule { }
