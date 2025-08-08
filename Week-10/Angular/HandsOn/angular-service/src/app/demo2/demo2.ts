import { Component } from '@angular/core';
import { Greet } from '../greet';
@Component({
  selector: 'app-demo2',
  imports: [],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css'
})
export class Demo2 {
  constructor(private greetService: Greet) {
    console.log(this.greetService.Hello())
  }
}
