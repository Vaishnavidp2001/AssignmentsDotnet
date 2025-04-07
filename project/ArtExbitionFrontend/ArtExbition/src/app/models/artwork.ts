import { Artworkgallery } from "./artworkgallery";
import { FavoriteArtWork } from "./favorite-art-work";

export interface Artwork {
 
  title: string | undefined;
  description?: string;
  creationDate?: Date;
  imageURL: string | undefined;
  artistId: number | undefined;

  favoriteArtworks?: FavoriteArtWork[];
  artworkGalleries?: Artworkgallery[];
}

 
  
