import { Artwork } from "./artwork";
import { Gallery } from "./gallery";

export interface Artworkgallery {

  artworkId?: number;
  galleryId?: number;
  artwork?: Artwork; // Navigation property
  gallery?: Gallery; // Navigation property
}
