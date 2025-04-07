import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArtworkGalleryComponent } from './artwork-gallery.component';

describe('ArtworkGalleryComponent', () => {
  let component: ArtworkGalleryComponent;
  let fixture: ComponentFixture<ArtworkGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArtworkGalleryComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArtworkGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
