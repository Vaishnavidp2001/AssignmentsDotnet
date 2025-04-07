import { TestBed } from '@angular/core/testing';

import { FavoriteArtWorkService } from './favorite-art-work.service';

describe('FavoriteArtWorkService', () => {
  let service: FavoriteArtWorkService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FavoriteArtWorkService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
