import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FavoriteArtWorkService {
  private apiUrl = 'http://localhost:5000/api/favoriteartworks'; // Update API URL as needed

  constructor(private http: HttpClient) {}

  // Fetch all favorite artworks
  getAllFavoriteArtworks(): Observable<FavoriteArtWork[]> {
    return this.http.get<FavoriteArtWork[]>(this.apiUrl);
  }

  // Fetch a favorite artwork by ID
  getFavoriteArtworkById(id: number): Observable<FavoriteArtWork> {
    return this.http.get<FavoriteArtWork>(`${this.apiUrl}/${id}`);
  }

  // Add new favorite artwork
  addFavoriteArtWork(favoriteArtwork: FavoriteArtWork): Observable<FavoriteArtWork> {
    return this.http.post<FavoriteArtWork>(this.apiUrl, favoriteArtwork);
  }

  // Remove favorite artwork
  deleteFavoriteArtwork(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}import { HttpClient } from '@angular/common/http';
import { FavoriteArtWork } from '../models/favorite-art-work';

