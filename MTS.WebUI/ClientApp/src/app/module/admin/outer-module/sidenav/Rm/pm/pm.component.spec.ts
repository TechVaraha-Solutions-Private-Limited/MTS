import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PmComponent } from './pm.component';

describe('PmComponent', () => {
  let component: PmComponent;
  let fixture: ComponentFixture<PmComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PmComponent]
    });
    fixture = TestBed.createComponent(PmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
