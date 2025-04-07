using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class FavouriteArtWorkRepository : IFavoriteArtWorkRepository
    {
        readonly ArtDBContext _artDbContext;
        public FavouriteArtWorkRepository(ArtDBContext artDbContext)
        {
            _artDbContext = artDbContext;
        }

        //getall
        public async Task<IEnumerable<FavoriteArtWork>>GetAllFavoriteArtwork()
        {
            return await _artDbContext.FavoriteArtWork.ToListAsync();
        }

        //addartwork
        public async Task<FavoriteArtWork> AddArtworkToFavorite(int userId, int artworkId)
        {
            var fav=new FavoriteArtWork { ArtworkId = artworkId ,UserId=userId};
            _artDbContext.FavoriteArtWork.Add(fav);
            await _artDbContext.SaveChangesAsync();
            return fav;

        }

        //GetFavoriteArtWorkById
        public async Task<FavoriteArtWork> GetFavoriteArtWorkById(int userId)
        {
            return await _artDbContext.FavoriteArtWork.FirstOrDefaultAsync(b => b.UserId == userId);
        }


        //RemoveArtworkFromFavorite
        public async Task<bool> RemoveArtworkFromFavorite(int userId)
        {
            var remov = await GetFavoriteArtWorkById(userId);
            if (remov is null)
            {
                _artDbContext.FavoriteArtWork.Remove(remov);
                return await _artDbContext.SaveChangesAsync()>0;
            }
            return false; 
        }

        

    }
}
