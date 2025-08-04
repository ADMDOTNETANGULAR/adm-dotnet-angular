import { Component } from '@angular/core';
import { Product } from '../product';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-demo3',
  imports: [CommonModule],
  templateUrl: './demo3.html',
  styleUrl: './demo3.css'
})
export class Demo3 {
  //initiate the product
  item: Product | null = null;
  constructor() {
    // Create a new product instance
    this.item = new Product(1, 'Laptop', 1500, 'High performance laptop');
  }
}
