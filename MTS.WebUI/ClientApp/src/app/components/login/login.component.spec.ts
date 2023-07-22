
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LoginComponent } from './login.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { By } from '@angular/platform-browser';
describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormsModule, HttpClientModule],
      declarations: [LoginComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the login component', () => {
    expect(component).toBeTruthy();
  });

  it('should submit the form when submit button is clicked', () => {
    spyOn(component, 'submitForm');
    const submitButton = fixture.nativeElement.querySelector('button[type="submit"]');
    submitButton.click();
    expect(component.submitForm).toHaveBeenCalled();
  });

  // it('should allow input with numbers, alphabets, and characters in the email field', () => {
  //   const emailInput = fixture.debugElement.query(By.css('#exampleInputEmail1'));
  //   const emailInputElement: HTMLInputElement = emailInput.nativeElement;
  
  //   // Set a valid email input with numbers, alphabets, and characters
  //   emailInputElement.value = 'test123@example.com';
  //   emailInputElement.dispatchEvent(new Event('input'));
  //   fixture.detectChanges();
  
  //   expect(component.formData.value.email).toBe('test123@example.com');
  // });
  
  
  

});
