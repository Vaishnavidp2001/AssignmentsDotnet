// import { Component } from '@angular/core';
// import { Artworkgallery } from '../../models/artworkgallery';


// @Component({
//   selector: 'app-artwork-gallery',
//   standalone: true,
//   imports: [],
//   templateUrl: './artwork-gallery.component.html',
//   styleUrl: './artwork-gallery.component.css'
// })
// export class ArtworkGalleryComponent {
//   artworkGalleries: ArtworkGallery[] = [];

//   constructor(private artworkGalleryService: ArtworkGalleryService) {}

//   ngOnInit(): void {
//     this.loadArtworkGalleries();
//   }

//   loadArtworkGalleries(): void {
//     this.artworkGalleryService.getAllArtworkGalleries().subscribe({
//       next: (data) => this.artworkGalleries = data,
//       error: (error) => console.error('Error fetching artwork-gallery data:', error)
//     });
//   }
// }
