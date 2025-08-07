import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Demo } from "./demo/demo";
import { Demo1 } from "./demo1/demo1";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Demo, Demo1],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-pipes');
}
