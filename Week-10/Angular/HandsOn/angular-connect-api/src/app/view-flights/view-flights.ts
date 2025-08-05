import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Flight } from '../flight';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-view-flights',
  imports: [CommonModule],
  templateUrl: './view-flights.html',
  styleUrl: './view-flights.css'
})
export class ViewFlights {
  flights: any[] = []; //array to hold flight data
  //initiate HttpClient with dependency injection
  constructor(private http: HttpClient) {
    this.http.get<Flight[]>('http://localhost:5184/api/Flight/GetAllFlights') //replace with your API endpoint
      .subscribe((response) => {
        this.flights = response; //store flight data in the array
        console.log(this.flights); //log flight data for debugging purposes
      });
  }
}
