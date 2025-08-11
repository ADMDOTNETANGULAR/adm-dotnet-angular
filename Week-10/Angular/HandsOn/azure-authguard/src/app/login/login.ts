import { Component } from '@angular/core';
import { AuthService } from '../auth-service';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-login',
  imports: [FormsModule, CommonModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  username = '';
  password = '';
  errorMessage = '';

  constructor(private authService: AuthService, private router: Router) { }

  onLogin() {
    if (this.authService.login(this.username, this.password)) {
      this.router.navigate(['/dashboard']);
    } else {
      this.errorMessage = 'Invalid credentials';
    }
  }
}
