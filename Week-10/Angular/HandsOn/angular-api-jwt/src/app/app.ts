import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { Login } from "./login/login";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Login, RouterLink, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-api-jwt');
  flag: boolean = false;
  constructor() {
    alert('Welcome to the Angular API JWT!');
    if (localStorage.getItem('active') == 'active') {
      this.flag = false;
    }
    else {
      this.flag = true;
    }

  }
}
