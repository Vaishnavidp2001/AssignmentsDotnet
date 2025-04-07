import { Component } from '@angular/core';
import { FavoriteArtWork } from '../../models/favorite-art-work';
import { FavoriteArtWorkService } from '../../Services/favorite-art-work.service';

@Component({
  selector: 'app-favorite-artwork',
  standalone: true,
  imports: [],
  templateUrl: './favorite-artwork.component.html',
  styleUrl: './favorite-artwork.component.css'
})
export class FavoriteArtworkComponent {
  favoriteArtworks: FavoriteArtWork[] = [];

  constructor(private favoriteArtworkService: FavoriteArtWorkService) {}

  ngOnInit(): void {
    this.loadFavoriteArtworks();
  }

  loadFavoriteArtworks(): void {
    this.favoriteArtworkService.getAllFavoriteArtworks().subscribe({
      next: (data) => this.favoriteArtworks = data,
      error: (error) => console.error('Error fetching favorite artworks:', error)
    });
  }
}
