using ArtExhibitionSystem.Domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IArtworkGalleryRepository
    {
        Task<ArtworkGallery> AddArtworkGallery(ArtworkGallery artworkGallery);
        Task<bool> DeleteArtworkGallery(int artworkId, int galleryId);



    }
}
