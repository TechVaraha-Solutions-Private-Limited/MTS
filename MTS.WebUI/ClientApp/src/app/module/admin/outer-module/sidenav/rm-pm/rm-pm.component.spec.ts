import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RMPMComponent } from './rm-pm.component';

describe('RMPMComponent', () => {
  let component: RMPMComponent;
  let fixture: ComponentFixture<RMPMComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RMPMComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RMPMComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
