import { TestBed } from '@angular/core/testing';

import { SLApiService } from './slapi.service';

describe('SLApiService', () => {
  let service: SLApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SLApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
