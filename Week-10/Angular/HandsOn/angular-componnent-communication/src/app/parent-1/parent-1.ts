import { Component } from '@angular/core';
import { Child1 } from "../child-1/child-1";

@Component({
  selector: 'app-parent-1',
  imports: [Child1],
  templateUrl: './parent-1.html',
  styleUrl: './parent-1.css'
})
export class Parent1 {
  parentMessage = '';
  onMessageReceived($event: any) {
    this.parentMessage = $event;
  }
}
