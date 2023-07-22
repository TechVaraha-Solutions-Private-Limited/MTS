import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContainerMasterComponent } from './container-master.component';

describe('ContainerMasterComponent', () => {
  let component: ContainerMasterComponent;
  let fixture: ComponentFixture<ContainerMasterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ContainerMasterComponent]
    });
    fixture = TestBed.createComponent(ContainerMasterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
