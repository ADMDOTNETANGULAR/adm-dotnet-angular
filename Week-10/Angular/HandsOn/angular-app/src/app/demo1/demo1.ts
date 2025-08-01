import { Component } from '@angular/core';
import { Student } from '../student';
import { Product } from '../product';
@Component({
  selector: 'app-demo1',
  imports: [],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css'
})
export class Demo1 {
  title: string = 'Demo Component';
  student: Student = new Student();
  product: Product;

  constructor() {
    this.student.id = 1;
    this.student.name = 'Hello';
    this.student.isStudent = true;
    this.product = new Product(1, 'Sample Product', 100.0, 'This is a sample product');

  }
}
