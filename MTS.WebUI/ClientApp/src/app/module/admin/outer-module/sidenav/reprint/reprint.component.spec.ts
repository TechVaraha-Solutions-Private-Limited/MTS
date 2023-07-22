import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReprintComponent } from './reprint.component';

describe('ReprintComponent', () => {
  let component: ReprintComponent;
  let fixture: ComponentFixture<ReprintComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReprintComponent]
    });
    fixture = TestBed.createComponent(ReprintComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
