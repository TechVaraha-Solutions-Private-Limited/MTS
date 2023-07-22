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

  it('should submit the form when the submit button is clicked', () => {
    spyOn(component, 'submitForm');
    const submitButton = fixture.nativeElement.querySelector('button[type="submit"]');
    submitButton.click();
    expect(component.submitForm).toHaveBeenCalled();
  });
//username valid funtion
  it('should update the email when a valid alphabet input is entered', () => {
    const nameInput = fixture.debugElement.query(By.css('input[name="name"]'));
    const inputElement = nameInput.nativeElement;
    inputElement.value = '';
    inputElement.dispatchEvent(new Event('input'));
    expect(component.name).toBe('');
  });

  it('should update the email when a valid character input is entered', () => {
    const nameInput = fixture.debugElement.query(By.css('input[name="name"]'));
    const inputElement = nameInput.nativeElement;
    inputElement.value = 'muthu';
    inputElement.dispatchEvent(new Event('input'));
    expect(component.name).toBe('muthu@123');
  });

  it('should update the email when a valid number input is entered', () => {
    const nameInput = fixture.debugElement.query(By.css('input[name="name"]'));
    const inputElement = nameInput.nativeElement;
    inputElement.value = 'johndoe@123';
    inputElement.dispatchEvent(new Event('input'));
    expect(component.name).toBe('');
  });

  it('should not update the email when an invalid input is entered', () => {
    const nameInput = fixture.debugElement.query(By.css('input[name="name"]'));
    const inputElement = nameInput.nativeElement;
    inputElement.value = '123'; 
    inputElement.dispatchEvent(new Event('input'));
    expect(component.name).toBe('');
  });

  
});
