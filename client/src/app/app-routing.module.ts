import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './shared/errors/not-found/not-found.component';

const routes: Routes = [
  { path: 'auth', loadChildren: () => import('./modules/auth/auth.module').then(m => m.AuthModule) },
  { path: 'exercise', loadChildren: () => import('./modules/exercise/exercise.module').then(m => m.ExerciseModule) },
  { path: 'workout', loadChildren: () => import('./modules/workout/workout.module').then(m => m.WorkoutModule) },
  { path: '', redirectTo: '/auth/register', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
