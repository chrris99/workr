import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
})
export class TitleComponent implements OnInit {
  @Input() title: string | undefined;
  @Input() text: string | undefined;

  constructor() { }

  ngOnInit(): void { }
}
