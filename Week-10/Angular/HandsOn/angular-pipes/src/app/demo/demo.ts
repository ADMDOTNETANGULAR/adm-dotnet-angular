import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-demo',
  imports: [CommonModule],
  templateUrl: './demo.html',
  styleUrl: './demo.css'
})
export class Demo {
  title: string = 'Pipe Demo';
  price: number = 345;
  bookingDate: Date = new Date(2021, 2, 21);
  obj: any = { Eid: 1, Ename: 'Rohan', Salary: 23000 };
}
