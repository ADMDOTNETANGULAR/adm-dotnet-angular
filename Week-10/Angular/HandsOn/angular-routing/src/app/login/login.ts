import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
  users: any[] = [{ username: 'admin', password: 'admin', role: 'admin' },
  { username: 'customer1', password: '12345', role: 'customer' }];
  username: string = '';
  password: string = '';
  errorMessage: string = '';
  constructor(private router: Router) { }//initate router object
  validate() {
    let user = this.users.find(u => u.username === this.username && u.password === this.password);
    if (user) {
      if (user.role === 'admin') {
        //navigate to admin dashboard
        this.router.navigateByUrl('/admin-dashboard');
      }
      else if (user.role === 'customer') {
        //navigate to customer dashboard
        this.router.navigateByUrl('/customer-dashboard');
      }
    }
    else
      this.errorMessage = 'Invalid username or password';
  }
}
