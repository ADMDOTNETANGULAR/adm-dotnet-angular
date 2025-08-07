import { Component } from '@angular/core';
import { CapitalizePipe } from '../capitalize-pipe';

@Component({
  selector: 'app-demo1',
  imports: [CapitalizePipe],
  templateUrl: './demo1.html',
  styleUrl: './demo1.css'
})
export class Demo1 {

}
