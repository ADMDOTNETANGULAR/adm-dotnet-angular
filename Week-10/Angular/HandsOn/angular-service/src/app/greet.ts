import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Greet {
  Hello(): string {
    return 'Hello From Angular Service!!!'
  }
}
