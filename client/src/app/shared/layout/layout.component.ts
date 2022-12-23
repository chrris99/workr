import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html'
})
export class LayoutComponent implements OnInit {
  @Input() title: string | undefined;
  @Input() text: string | undefined;

  constructor() { }

  ngOnInit(): void { }
}
