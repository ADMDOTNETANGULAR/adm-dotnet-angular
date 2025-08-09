import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-child-1',
  imports: [],
  templateUrl: './child-1.html',
  styleUrl: './child-1.css'
})
export class Child1 {
  message: string = 'Hello from Child 1!';
  @Output() eventObject = new EventEmitter<string>();
  sendMessage() {
    this.eventObject.emit(this.message);
  }
}
