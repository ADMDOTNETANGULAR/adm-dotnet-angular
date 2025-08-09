import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Parent } from "./parent/parent";
import { Parent1 } from "./parent-1/parent-1";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Parent, Parent1],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-componnent-communication');
}
