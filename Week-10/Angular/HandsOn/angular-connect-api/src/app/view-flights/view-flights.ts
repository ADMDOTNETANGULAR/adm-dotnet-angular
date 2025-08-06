import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Flight } from '../flight';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-view-flights',
  imports: [CommonModule],
  templateUrl: './view-flights.html',
  styleUrl: './view-flights.css'
})
export class ViewFlights implements OnInit {
  flights: any[] = []; //array to hold flight data
  //initiate HttpClient with dependency injection
  constructor(private http: HttpClient) {

  }
  ngOnInit(): void {
    this.http.get<Flight[]>('http://localhost:5184/api/Flight/GetAllFlights') //replace with your API endpoint
      .subscribe((response) => {
        this.flights = response; //store flight data in the array
        console.log(this.flights); //log flight data for debugging purposes
      });
  }
  deleteFlight(flightId: number) {
    this.http.delete(`http://localhost:5184/api/Flight/DeleteFlight?id=${flightId}`)
      .subscribe(data => {
        console.log(data);
        this.flights = this.flights.filter(f => f.flightId !== flightId); //remove deleted flight from the array
      }); // Add your API endpoint here
  }
}
