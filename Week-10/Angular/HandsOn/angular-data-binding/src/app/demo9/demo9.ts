import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Book } from '../book';
@Component({
  selector: 'app-demo9',
  imports: [CommonModule, FormsModule],
  templateUrl: './demo9.html',
  styleUrl: './demo9.css'
})
export class Demo9 {
  authors: string[] = ['Author1', 'Author2', 'Author3'];
  book: Book = {
    id: 0,
    title: '',
    price: 0,
    author: ''
  }
  books: Book[] = []; //empty array to hold multiple books
  SaveBook() {
    console.log(this.book); //log the array of books to the console
    this.book.id = this.books.length + 1; //increment id by 1 for each new book
    this.books.push(this.book); //add new book to the array
    // Reset the book object to clear the form fields
    this.Clear(); //clear the form fields
    console.log(this.books); //log the updated array of books to the console
  }

  private Clear() {
    this.book = {
      id: 0,
      title: '',
      price: 0,
      author: ''
    };
  }
}