// import { HttpClient } from '@angular/common/http';
// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class ArtworkgalleryService {
//   private apiUrl = 'http://localhost:5000/api/artworkgalleries'; // Update API URL as needed

//   constructor(private http: HttpClient) {}

//   // Fetch all artwork-gallery relations
//   getAllArtworkGalleries(): Observable<ArtworkGallery[]> {
//     return this.http.get<ArtworkGallery[]>(this.apiUrl);
//   }

//   // Fetch a specific artwork-gallery entry by Artwork ID and Gallery ID
//   getArtworkGalleryById(artworkId: number, galleryId: number): Observable<ArtworkGallery> {
//     return this.http.get<ArtworkGallery>(`${this.apiUrl}/${artworkId}/${galleryId}`);
//   }

//   // Add a new artwork-gallery relation
//   addArtworkGallery(artworkGallery: ArtworkGallery): Observable<ArtworkGallery> {
//     return this.http.post<ArtworkGallery>(this.apiUrl, artworkGallery);
//   }

//   // Remove an artwork from a gallery
//   deleteArtworkGallery(artworkId: number, galleryId: number): Observable<void> {
//     return this.http.delete<void>(`${this.apiUrl}/${artworkId}/${galleryId}`);
//   }
 
// }
