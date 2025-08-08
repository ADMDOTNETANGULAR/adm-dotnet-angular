import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FligtService {
  constructor(private http: HttpClient) { }
  getallFlights() {
    return this.http.get<any>('http://localhost:5184/api/Flight/GetAllFlights');
  }
}
