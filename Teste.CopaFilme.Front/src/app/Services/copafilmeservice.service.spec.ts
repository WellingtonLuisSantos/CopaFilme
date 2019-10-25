import { TestBed } from '@angular/core/testing';

import { CopafilmeserviceService } from './copafilmeservice.service';

describe('CopafilmeserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CopafilmeserviceService = TestBed.get(CopafilmeserviceService);
    expect(service).toBeTruthy();
  });
});
