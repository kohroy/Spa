import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  constructor(title: Title) {
    title.setTitle("计数");
  }

  public incrementCounter() {
    this.currentCount++;
  }
}
