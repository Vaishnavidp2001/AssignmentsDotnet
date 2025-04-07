import { Artwork } from './artwork';
import { Gallery } from './gallery';

export interface Artist {
  artistName: string ;
  artistBirthdate?: Date;
  artistPhone?: string;
  artworks?: Artwork[]; // List of artworks by the artist
  galleries?: Gallery[]; // List of galleries associated with the artist
}


 