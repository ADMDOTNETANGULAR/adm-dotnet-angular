import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Book } from '../book';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-demo8',
  imports: [FormsModule, CommonModule],
  templateUrl: './demo8.html',
  styleUrl: './demo8.css'
})
export class Demo8 {
  authors: string[] = ['Author1', 'Author2', 'Author3'];
  book: Book = {
    id: 0,
    title: '',
    price: 0,
    author: ''
  }
}
