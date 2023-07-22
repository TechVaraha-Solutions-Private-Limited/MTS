import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaterialTrackingComponent } from './material-tracking.component';

describe('MaterialTrackingComponent', () => {
  let component: MaterialTrackingComponent;
  let fixture: ComponentFixture<MaterialTrackingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MaterialTrackingComponent]
    });
    fixture = TestBed.createComponent(MaterialTrackingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
