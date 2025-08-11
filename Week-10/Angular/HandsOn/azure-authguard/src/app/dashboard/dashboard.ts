import { Component } from '@angular/core';
import { AuthService } from '../auth-service';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css'
})
export class Dashboard {
  constructor(private authService: AuthService) { }

  logout() {
    this.authService.logout();
  }
}
