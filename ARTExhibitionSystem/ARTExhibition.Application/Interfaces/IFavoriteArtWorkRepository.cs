using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;

namespace ARTExhibition.Application.Interfaces
{
    public interface IFavoriteArtWorkRepository
    {
        Task<IEnumerable<FavoriteArtWork>> GetUserFavoritesAsync(int userId);
        Task<bool> AddFavoriteAsync(int userId, int artworkId); // Updated method signature
       Task RemoveFavoriteAsync(int userId, int artworkId);
        Task<bool> AddFavoriteArtWorkAsync(int userID, int artworkID);
        Task<bool> DeleteFavoriteArtWorkAsync(int userID, int artworkID);
       // Task<bool> AddFavoriteArtWorkAsync(int userID, int artworkID);
    }
}
