import { TestBed } from '@angular/core/testing';

import { InwardServicesService } from './inward-services.service';

describe('InwardServicesService', () => {
  let service: InwardServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InwardServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
