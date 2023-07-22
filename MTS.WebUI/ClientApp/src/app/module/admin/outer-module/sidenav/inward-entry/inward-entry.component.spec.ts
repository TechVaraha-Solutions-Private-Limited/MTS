import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InwardEntryComponent } from './inward-entry.component';

describe('InwardEntryComponent', () => {
  let component: InwardEntryComponent;
  let fixture: ComponentFixture<InwardEntryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [InwardEntryComponent]
    });
    fixture = TestBed.createComponent(InwardEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
