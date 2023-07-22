import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private authService: AuthService) { }

  getUsername(): Observable<string> {
    if (this.authService.isAuthenticated()) {

      const username = this.authService.getUsername();
      if (username == 'vignesh') {
        return of('vignesh');
      } else if (username == 'muthu') {
        return of('muthu');
      } else if (username == 'naveen') {
        return of('naveen');
      }
      return of('naveen');
    }

    // Add a default return statement or handle the case when the username doesn't match any conditions.
    return of('defaultUsername');
  }
}
