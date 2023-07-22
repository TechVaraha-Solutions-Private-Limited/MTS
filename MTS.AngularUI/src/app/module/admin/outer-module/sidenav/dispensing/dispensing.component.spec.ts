import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DispensingComponent } from './dispensing.component';

describe('DispensingComponent', () => {
  let component: DispensingComponent;
  let fixture: ComponentFixture<DispensingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DispensingComponent]
    });
    fixture = TestBed.createComponent(DispensingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
