import { Component } from '@angular/core';
import { ArtworkService } from '../../Services/artwork.service';
import { Artwork } from '../../models/artwork';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-artwork',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './artwork.component.html',
  styleUrl: './artwork.component.css'
})
export class ArtworkComponent {

  artworks: Artwork[] = [];

  constructor(private artworkService: ArtworkService) {}

  ngOnInit(): void {
    this.loadArtworks();
  }

  loadArtworks(): void {
    this.artworkService.getAllArtworks().subscribe({
      next: (data) => {
        console.log("API Response:", data); 
        this.artworks = data;
        this.artworks.forEach(art => console.log("Image URL:", art.imageURL)); 
      },
      error: (error) => console.error("Error fetching artworks:", error)
    });
  }
  
  
}
