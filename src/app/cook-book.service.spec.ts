import { TestBed } from '@angular/core/testing';

import { CookBookService } from './cook-book.service';

describe('CookBookService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CookBookService = TestBed.get(CookBookService);
    expect(service).toBeTruthy();
  });
});
