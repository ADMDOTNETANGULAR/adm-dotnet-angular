import { Component } from '@angular/core';
import { Demo } from './demo/demo';
import { Demo2 } from './demo2/demo2';
import { Demo3 } from './demo3/demo3';
import { Demo4 } from './demo4/demo4';
import { Demo5 } from './demo5/demo5';
import { Count } from './count/count';
import { Demo6 } from './demo6/demo6';

@Component({
  selector: 'app-root',
  imports: [Demo, Demo2, Demo3, Demo4, Demo5, Count, Demo6],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

}
