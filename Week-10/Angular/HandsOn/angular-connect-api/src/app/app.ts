import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ViewFlights } from "./view-flights/view-flights";
import { AddFlight } from "./add-flight/add-flight";

@Component({
  selector: 'app-root',
  imports: [ViewFlights, AddFlight],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-connect-api');
}
