import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HdpeComponent } from './hdpe.component';

describe('HdpeComponent', () => {
  let component: HdpeComponent;
  let fixture: ComponentFixture<HdpeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HdpeComponent]
    });
    fixture = TestBed.createComponent(HdpeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
