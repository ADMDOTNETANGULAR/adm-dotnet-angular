import { Component } from '@angular/core';
import { Book } from '../book';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-demo7',
  imports: [FormsModule],
  templateUrl: './demo7.html',
  styleUrl: './demo7.css'
})
export class Demo7 {
  id: number = 0;
  name: string = '';
  price: number = 0;
  author: string = '';
  book: Book | null = null;
  SaveBook() {
    // Create a new book object with the provided details
    // and assign it to the book property
    this.book = {
      id: this.id,
      title: this.name,
      price: this.price,
      author: this.author
    }
    console.log(this.book);
  }

}
