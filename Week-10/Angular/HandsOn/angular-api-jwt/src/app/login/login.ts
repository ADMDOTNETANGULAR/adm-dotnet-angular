import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginDto } from '../login-dto';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  imports: [FormsModule],
  standalone: true,
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  login: LoginDto = { email: '', password: '' };
  errMessage: string = '';
  constructor(private http: HttpClient, private router: Router) { }

  loginUser() {
    this.http.post<any>('http://localhost:5197/api/User/Login', this.login)
      .subscribe(data => {
        console.log(data);
        if (data != null) {
          // Store JWT token in local storage for future use
          localStorage.setItem('jwt', data.token);
          localStorage.setItem('active',"active")
          if (data.role === 'Admin') {
            this.router.navigate(['/admin-dashboard']);
          }
          else if (data.role == 'User') {
            this.router.navigate(['/user-dashboard']);
          }
        }
        else {
          // Handle login failure
          this.errMessage = "Invalid email or password. Please try again.  ";
         // console.log(this.errMessage);
        }

      });
  }
}
