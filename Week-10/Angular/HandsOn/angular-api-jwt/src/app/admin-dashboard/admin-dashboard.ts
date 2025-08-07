import { Component } from '@angular/core';
import { RouterLink, RouterOutlet, Router } from '@angular/router';


@Component({
  selector: 'app-admin-dashboard',
  imports: [RouterOutlet, RouterLink],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.css'
})
export class AdminDashboard {
  constructor(private router: Router) { }
  LogOut() {
    //alert('Hello, you have logged out! Goodbye! :');
    localStorage.clear();
    localStorage.removeItem('token'); // Remove token from local storage
    localStorage.setItem('active', 'inactive'); // Set user status to inactive
    // Implement logic to log out user
    this.router.navigateByUrl('/login'); // Redirect to login page after logout
  }


}
