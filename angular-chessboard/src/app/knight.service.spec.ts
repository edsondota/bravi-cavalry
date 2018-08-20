import { TestBed, inject } from '@angular/core/testing';

import { knightService } from './knight.service';

describe('KnightService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [knightService]
    });
  });

  it('should be created', inject([knightService], (service: knightService) => {
    expect(service).toBeTruthy();
  }));
});
