import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercise-card',
  templateUrl: './exercise-card.component.html'
})
export class ExerciseCardComponent implements OnInit {

  @Input() name: string = "";
  @Input() description: string = "";
  @Input() type: string = "";

  constructor() { }

  ngOnInit(): void { }
}
