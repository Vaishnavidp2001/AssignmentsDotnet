import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Artwork } from '../../app/models/artwork';

@Injectable({
  providedIn: 'root'
})
export class ArtworkService {
  private apiUrl = 'https://localhost:7084/api/Artworks'; // Update the API URL as needed

  constructor(private http: HttpClient) {}

  // Fetch all artworks
  getAllArtworks(): Observable<Artwork[]> {
    return this.http.get<Artwork[]>(this.apiUrl);
  }

  // // Fetch artwork by ID
  // getArtworkById(id: number): Observable<Artwork> {
  //   return this.http.get<Artwork>(`${this.apiUrl}/${id}`);
  // }

  // // Add new artwork
  // addArtwork(artwork: Artwork): Observable<Artwork> {
  //   return this.http.post<Artwork>(this.apiUrl, artwork);
  // }

  // // Update existing artwork
  // updateArtwork(id: number, artwork: Artwork): Observable<Artwork> {
  //   return this.http.put<Artwork>(`${this.apiUrl}/${id}`, artwork);
  // }

  // // Delete artwork
  // deleteArtwork(id: number): Observable<void> {
  //   return this.http.delete<void>(`${this.apiUrl}/${id}`);
  // }

  
}
