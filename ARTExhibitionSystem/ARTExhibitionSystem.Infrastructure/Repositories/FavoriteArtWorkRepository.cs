//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ARTExhibitionSystem.Domain.Entities;
//using ARTExhibitionSystem.Infrastructure.Context;
//using Microsoft.EntityFrameworkCore;
//using ARTExhibition.Application.Interfaces;

//namespace ARTExhibitionSystem.Infrastructure.Repositories;
//{
//    public class FavoriteArtWorkRepository : IFavoriteArtWorkRepository
//{
//    private readonly ApplicationDbContext _context;

//    public FavoriteArtWorkRepository(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IEnumerable<FavoriteArtWork>> GetUserFavoritesAsync(int userId)
//    {
//        return await _context.FavoriteArtWorks
//            .Where(f => f.UserID == userId)
//            .ToListAsync();
//    }

//    public async Task AddFavoriteAsync(int userId, int artworkId)
//    {
//        var favorite = new FavoriteArtWork
//        {
//            UserID = userId,
//            ArtworkID = artworkId
//        };
//        await _context.FavoriteArtWorks.AddAsync(favorite);
//        await _context.SaveChangesAsync();

//    }

//    public async Task RemoveFavoriteAsync(int userId, int artworkId)
//    {
//        var favorite = await _context.FavoriteArtWorks
//            .FirstOrDefaultAsync(f => f.UserID == userId && f.ArtworkID == artworkId);
//        if (favorite != null)
//        {
//            _context.FavoriteArtWorks.Remove(favorite);
//            await _context.SaveChangesAsync();
//        }
//    } 
//}



using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ARTExhibition.Application.Interfaces;

namespace ARTExhibitionSystem.Infrastructure.Repositories
{
    public class FavoriteArtWorkRepository : IFavoriteArtWorkRepository
    {
        private readonly ApplicationDbContext _context;

        public FavoriteArtWorkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FavoriteArtWork>> GetUserFavoritesAsync(int userId)
        {
            return await _context.FavoriteArtWorks
                .Where(f => f.UserID == userId)
                .ToListAsync();
        }

        //public async Task<bool> AddFavoriteAsync(int userId, int artworkId) // Updated method signature
        //{
        //    var favoriteArtWork = new FavoriteArtWork
        //    {
        //        UserID = userId,
        //        ArtworkID = artworkId
        //    };

        //    await _context.FavoriteArtWorks.AddAsync(favoriteArtWork);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        public async Task<bool> AddFavoriteArtWorkAsync(int userID, int artworkID)
        {
            // Check if the favorite artwork already exists
            var existingFavorite = await _context.FavoriteArtWorks
                .FirstOrDefaultAsync(f => f.UserID == userID && f.ArtworkID == artworkID);

            if (existingFavorite != null)
            {
                
                return false; 
            }

            // Create a new instance of FavoriteArtWork
            var favoriteArtWork = new FavoriteArtWork
            {
                UserID = userID,
                ArtworkID = artworkID
            };

            // Add the favorite artwork to the context
            await _context.FavoriteArtWorks.AddAsync(favoriteArtWork);
            await _context.SaveChangesAsync();
 
            return true;
        }

        public async Task RemoveFavoriteAsync(int userId, int artworkId)
        {
            var favorite = await _context.FavoriteArtWorks
                .FirstOrDefaultAsync(f => f.UserID == userId && f.ArtworkID == artworkId);
            if (favorite != null)
            {
                _context.FavoriteArtWorks.Remove(favorite);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> DeleteFavoriteArtWorkAsync(int userID, int artworkID)
        {
            var favorite = await _context.FavoriteArtWorks
                .FirstOrDefaultAsync(f => f.UserID == userID && f.ArtworkID == artworkID);

            if (favorite != null)
            {
                _context.FavoriteArtWorks.Remove(favorite);
                await _context.SaveChangesAsync();
                return true; // Return true if deletion was successful
            }

            return false; // Return false if no favorite was found to delete
        }

        public Task<bool> AddFavoriteAsync(int userId, int artworkId)
        {
            throw new NotImplementedException();
        }
    }

}