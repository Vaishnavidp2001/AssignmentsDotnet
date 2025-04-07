using ArtExhibitionSystem.domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IGalleriesRepository
    {
        Task<IEnumerable<Galleries>> GetAllGalleries();
        Task<Galleries>AddGalleries(Galleries galleries);
        Task<Galleries> GetGalleryById(int galleryId);
        Task<Galleries> UpdateGallery(Galleries galleries);
        Task<bool> RemoveGalleries(int galleryId);


    }
}
