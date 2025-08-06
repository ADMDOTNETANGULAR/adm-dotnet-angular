import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Flight } from '../flight';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-edit-flight',
  imports: [FormsModule],
  templateUrl: './edit-flight.html',
  styleUrl: './edit-flight.css'
})
export class EditFlight {
  flight: Flight = { flightCode: '', flightId: 0, flightName: '', seats: 0 };
  constructor(private http: HttpClient) { } // Add your HTTP client here
  serachFlight(flightId: number) {
    this.http.get<Flight>(`http://localhost:5184/api/Flight/GetFlightById/${flightId}`)
      .subscribe((response) => {
        this.flight = response; //store flight data in the form
        console.log(this.flight); //log flight data for debugging purposes
      });
  }
  editFlight() {
    this.http.put('http://localhost:5184/api/Flight/UpdateFlight', this.flight)
      .subscribe(data => {
        console.log(data);
        this.flight = { flightCode: '', flightId: 0, flightName: '', seats: 0 }; // Reset the form
      }); // Add your API endpoint here
  }
  deletFlight(flightId: number) {
    this.http.delete(`http://localhost:5184/api/Flight/DeleteFlight?id=${flightId}`)
      .subscribe(data => {
        console.log(data);
        this.flight = { flightCode: '', flightId: 0, flightName: '', seats: 0 }; // Reset the form
      }); // Add your API endpoint here
  }
}
