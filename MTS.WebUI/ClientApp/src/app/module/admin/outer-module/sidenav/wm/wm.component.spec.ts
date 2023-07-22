import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WmComponent } from './wm.component';

describe('WmComponent', () => {
  let component: WmComponent;
  let fixture: ComponentFixture<WmComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WmComponent]
    });
    fixture = TestBed.createComponent(WmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
