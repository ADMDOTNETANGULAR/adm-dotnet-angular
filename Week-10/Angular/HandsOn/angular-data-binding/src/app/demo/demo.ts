import { Component } from '@angular/core';

@Component({
  selector: 'app-demo',
  imports: [],
  templateUrl: './demo.html',
  styleUrl: './demo.css'
})
export class Demo {
  stuent_name: string = 'John Doe';
  student_age: number = 20;
  student_grade: string = 'A';
}
