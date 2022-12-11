import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout/layout.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { NavbarComponent } from './components/navbar/navbar.component';

@NgModule({
  declarations: [
    LayoutComponent,
    SideMenuComponent,
    NotFoundComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    LayoutComponent,
    NotFoundComponent
  ]
})
export class SharedModule { }
