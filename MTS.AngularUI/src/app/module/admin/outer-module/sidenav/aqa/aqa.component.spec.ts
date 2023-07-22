import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AqaComponent } from './aqa.component';

describe('AqaComponent', () => {
  let component: AqaComponent;
  let fixture: ComponentFixture<AqaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AqaComponent]
    });
    fixture = TestBed.createComponent(AqaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
