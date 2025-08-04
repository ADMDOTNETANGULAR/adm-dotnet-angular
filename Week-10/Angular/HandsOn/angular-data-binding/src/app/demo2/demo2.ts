import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-demo2',
  imports: [CommonModule],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css'
})
export class Demo2 {
  cities: string[] = ['New York', 'Los Angeles', 'Chicago'];
}
