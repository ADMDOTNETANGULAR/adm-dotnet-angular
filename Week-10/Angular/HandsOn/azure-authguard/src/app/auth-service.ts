import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private tokenKey = 'auth_token';

  constructor(private router: Router) { }

  // Mock login - replace with API call
  login(username: string, password: string): boolean {
    if (username === 'admin' && password === 'admin123') {
      localStorage.setItem(this.tokenKey, 'mock-jwt-token-12345');
      return true;
    }
    return false;
  }

  logout(): void {
    localStorage.removeItem(this.tokenKey);
    this.router.navigate(['/login']);
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem(this.tokenKey); // Check if token exists in local storage and checks strict true value or false value
  }

  getToken(): string | null {
    return localStorage.getItem(this.tokenKey);
  }
}
