import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StatusLabelPrintingComponent } from './status-label-printing.component';

describe('StatusLabelPrintingComponent', () => {
  let component: StatusLabelPrintingComponent;
  let fixture: ComponentFixture<StatusLabelPrintingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StatusLabelPrintingComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StatusLabelPrintingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
