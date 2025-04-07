using ArtExhibitionSystem.domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IArtworkRepository
    {
        Task<IEnumerable<Artworks>> GetAllArtwork();
        Task<Artworks> AddArtworkAsync(Artworks artwork);
        Task<Artworks> GetArtworkByIdAsync(int artworkId);
        Task<Artworks> UpdateArtworkAsync(Artworks artwork);
        Task<bool> RemoveArtworkAsync(int artworkId);
       // Task<List<Artworks>> SearchArtworksAsync(string keyword);

    }

}
