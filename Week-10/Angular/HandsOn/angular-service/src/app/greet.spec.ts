import { TestBed } from '@angular/core/testing';

import { Greet } from './greet';

describe('Greet', () => {
  let service: Greet;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Greet);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
