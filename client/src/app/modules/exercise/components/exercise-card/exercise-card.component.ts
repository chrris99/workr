import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercise-card',
  templateUrl: './exercise-card.component.html'
})
export class ExerciseCardComponent implements OnInit {

  @Input() name: string = "";
  @Input() description: string = "";
  @Input() muscles: string[] = [];
  @Input() type: string = "";
  @Input() icon: string = "";

  constructor() { }

  ngOnInit(): void { }
}
