import { Component } from '@angular/core';

@Component({
  selector: 'app-count',
  imports: [],
  templateUrl: './count.html',
  styleUrl: './count.css'
})
export class Count {
  count: number = 0;
  increment() {
    this.count++;
  }
  reset() {
    this.count = 0;
  }
  decrement() {
    if (this.count > 0) {
      this.count--;
    }
  }
}
