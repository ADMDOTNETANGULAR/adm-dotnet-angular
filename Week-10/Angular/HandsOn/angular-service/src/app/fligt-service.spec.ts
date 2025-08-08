import { TestBed } from '@angular/core/testing';

import { FligtService } from './fligt-service';

describe('FligtService', () => {
  let service: FligtService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FligtService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
