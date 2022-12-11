import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExerciseDetailComponent } from './components/exercise-detail/exercise-detail.component';
import { ExerciseListComponent } from './components/exercise-list/exercise-list.component';

const routes: Routes = [
  { path: '', component: ExerciseListComponent },
  { path: '/:id', component: ExerciseDetailComponent }
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
