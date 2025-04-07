using ArtExhibitionSystem.Domain;

namespace ArtExhibitionSystem.application.Interfaces
{
    public interface IFavoriteArtWorkRepository
    {
        Task<IEnumerable<FavoriteArtWork>>GetAllFavoriteArtwork();
        Task<FavoriteArtWork> AddArtworkToFavorite(int userId, int artworkId);
        Task<FavoriteArtWork> GetFavoriteArtWorkById(int userId);
        Task<bool> RemoveArtworkFromFavorite(int userId);



    }
}
