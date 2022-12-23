import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from "@angular/router";
import { LayoutComponent } from './layout/layout.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { TitleComponent } from './components/title/title.component';

@NgModule({
  declarations: [
    LayoutComponent,
    SideMenuComponent,
    NotFoundComponent,
    NavbarComponent,
    TitleComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule
  ],
  exports: [
    LayoutComponent,
    NotFoundComponent,
    TitleComponent
  ]
})
export class SharedModule { }
