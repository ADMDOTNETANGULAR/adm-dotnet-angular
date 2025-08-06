import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Flight } from '../flight';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-add-flight',
  imports: [FormsModule],
  templateUrl: './add-flight.html',
  styleUrl: './add-flight.css'
})
export class AddFlight {
  flight: Flight = { flightCode: '', flightId: 0, flightName: '', seats: 0 };
  constructor(private http: HttpClient) { } // Add your HTTP client here
  //addFlight method to send the flight object to the API endpoint
  addFlight() {
    console.log(this.flight); // Log the flight object for debugging purposes
    this.http.post('http://localhost:5184/api/Flight/AddFlight', this.flight)
      .subscribe(data => {
        console.log(data);
        this.flight = { flightCode: '', flightId: 0, flightName: '', seats: 0 }; // Reset the form
      });
  } // Add your API endpoint here
}
