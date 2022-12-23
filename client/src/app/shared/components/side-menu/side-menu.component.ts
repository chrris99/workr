import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html'
})
export class SideMenuComponent implements OnInit {
  constructor(public auth: AuthService) { }

  ngOnInit(): void { }

  public logout(): void {
    this.auth.logout();
  }
}
