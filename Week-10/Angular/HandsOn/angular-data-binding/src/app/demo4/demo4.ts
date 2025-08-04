import { Component } from '@angular/core';
import { Movie } from '../movie';
@Component({
  selector: 'app-demo4',
  imports: [],
  templateUrl: './demo4.html',
  styleUrl: './demo4.css'
})
export class Demo4 {
  //initiate array of movies
  movies: Movie[] = [];
  constructor() {
    // Create a list of movies
    this.movies = [
      { id: 1, title: 'Inception', director: 'Christopher Nolan', releaseYear: 2010, genre: 'Sci-Fi' },
      { id: 2, title: 'The Godfather', director: 'Francis Ford Coppola', releaseYear: 1972, genre: 'Crime' },
      { id: 3, title: 'The Dark Knight', director: 'Christopher Nolan', releaseYear: 2008, genre: 'Action' }
    ];
  }
}
