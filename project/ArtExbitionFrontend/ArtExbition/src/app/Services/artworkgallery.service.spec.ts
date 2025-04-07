import { TestBed } from '@angular/core/testing';

import { ArtworkgalleryService } from './artworkgallery.service';

describe('ArtworkgalleryService', () => {
  let service: ArtworkgalleryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ArtworkgalleryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
