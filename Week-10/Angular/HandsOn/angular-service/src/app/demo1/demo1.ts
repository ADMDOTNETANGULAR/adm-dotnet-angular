import { Component } from '@angular/core';
import { Greet } from '../greet';
import { FligtService } from '../fligt-service';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-demo1',
  imports: [CommonModule],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css'
})
export class Demo1 {
  message: string = '';
  flights: any;
  //inject the Greet service
  constructor(private greetService: Greet, private flightService: FligtService) {
    this.message = this.greetService.Hello();//call the Hello method
    this.flightService.getallFlights()
      .subscribe((data: any) => {
        this.flights = data
      }); //call the getFlights method to get the flight data
  }

  //call the greet method

}
