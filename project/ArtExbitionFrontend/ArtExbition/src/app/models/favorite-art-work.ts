import { Artwork } from "./artwork";

export interface FavoriteArtWork {

    userId?: number;
    artworkId?: number;
    artwork?: Artwork; // Navigation property
}
