import { Component } from '@angular/core';
import { Child } from "../child/child";

@Component({
  selector: 'app-parent',
  imports: [Child],
  templateUrl: './parent.html',
  styleUrl: './parent.css'
})
export class Parent {
  parentMesage: string = "Hello Child Component";
  changeMessage() {
    this.parentMesage = "Goodbye Child Component! I've changed the message.";
  }
}
