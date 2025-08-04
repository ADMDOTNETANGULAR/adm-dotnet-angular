import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-demo6',
  imports: [FormsModule],
  templateUrl: './demo6.html',
  styleUrl: './demo6.css'
})
export class Demo6 {
  name: string = "Virat";

  changeName() {
    this.name = "Rohit";
  }
}
