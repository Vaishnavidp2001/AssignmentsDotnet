import { Artist } from "./artist";
import { Artwork } from "./artwork";

export class Gallery {

    name: string | undefined;
    description?: string;
    location?: string;
    artistId: number | undefined; // Foreign Key
    artist?: Artist; // Navigation Property
    artworkGalleries?: Artwork[]; // List of artworks in the gallery
}
