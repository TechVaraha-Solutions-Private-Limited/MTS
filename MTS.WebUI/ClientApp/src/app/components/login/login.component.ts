import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/components/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  options: string[] = ['ML24', 'ML11'];
  formData: any = {};
  onScroll(event: any) {
  
  }
  constructor(private authService: AuthService, private router: Router) {}

  submitForm() {
    const username = this.formData.email;
    const password = this.formData.password;

    this.authService.login(username, password).subscribe(
      (response: any) => {
        if (response.token) {
          this.authService.setToken(response.token,response.user);
          this.router.navigate(['/admin/home']);
        }    
      },
      (error: any) => {
        alert('Invalid username or password.');
      }
    );
  }
}


// import { Component } from '@angular/core';
// import { Router } from '@angular/router';
// import { AuthService } from 'src/app/components/auth.service';

// @Component({
//   selector: 'app-login',
//   templateUrl: './login.component.html',
//   styleUrls: ['./login.component.css'],
// })
// export class LoginComponent {
//   options: string[] = ['ML24', 'ML11'];
//   formData: any = {};
//   onScroll(event: any) {
  
//   }
//   constructor(private authService: AuthService, private router: Router) {}

//   submitForm() {
//     const username = this.formData.email;
//     const password = this.formData.password;

//     this.authService.login(username, password).subscribe(
//       (response: any) => {
//         if (response.token) {
//           this.authService.setToken(response.token);
//           this.router.navigate(['/admin/home']);
//         }    
//       },
//       (error: any) => {
//         alert('Invalid username or password.');
//       }
//     );
//   }
// }