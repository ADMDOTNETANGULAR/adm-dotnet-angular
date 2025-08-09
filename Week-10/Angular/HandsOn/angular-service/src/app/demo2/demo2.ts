import { Component } from '@angular/core';
import { Greet } from '../greet';
import { FligtService } from '../fligt-service';
@Component({
  selector: 'app-demo2',
  imports: [],
  templateUrl: './demo2.html',
  styleUrl: './demo2.css'
})
export class Demo2 {
  flights: any; //declare a variable to hold the flight data
  constructor(private greetService: Greet, private flightService: FligtService) {
    console.log(this.greetService.Hello())
    this.flightService.getallFlights()
      .subscribe((data: any) => {
        this.flights = data
      }); //call the getFlights method to get the flight data
  }
}
