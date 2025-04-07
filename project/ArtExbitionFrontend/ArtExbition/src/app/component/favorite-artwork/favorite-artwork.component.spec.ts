import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoriteArtworkComponent } from './favorite-artwork.component';

describe('FavoriteArtworkComponent', () => {
  let component: FavoriteArtworkComponent;
  let fixture: ComponentFixture<FavoriteArtworkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FavoriteArtworkComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FavoriteArtworkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
