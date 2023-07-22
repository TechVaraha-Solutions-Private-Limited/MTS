import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';


interface ApiResponse {
  message: string;
  token: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient, private router: Router) {}

  login(username: string, password: string): Observable<ApiResponse> {
    return this.http.post<ApiResponse>('/api/users', { username, password });
  }

  setToken(token: string, user:string): void {
    localStorage.setItem('token', token);
    localStorage.setItem("user", user);
  }

  getToken(): string | null {
    const token = localStorage.getItem('token');
    return token;
  }

  logout(): void {
    localStorage.removeItem('token');
    this.router.navigate(['/Login']);
  }

  isAuthenticated(): boolean {
    return this.getToken() !== null;
  }

  getUserName(): string | null {
    const token = localStorage.getItem('user');
    return token;
  }
  getUsername(): string {
    const username = this.getUserName();
    if (username) {
      return username;
    } else {
      return 'dds';
    }
  }
}
