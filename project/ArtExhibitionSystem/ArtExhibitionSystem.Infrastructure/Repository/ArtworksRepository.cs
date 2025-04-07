using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class ArtworksRepository:IArtworkRepository
    {
        readonly ArtDBContext _artDbContext;
        public ArtworksRepository(ArtDBContext artDBContext)
        {
            _artDbContext=artDBContext;
        }

        //getall
        public async Task<IEnumerable<Artworks>> GetAllArtwork()
        {
            return await _artDbContext.Artworks.ToListAsync();
        }

        //add
        public async Task<Artworks> AddArtworkAsync(Artworks artwork)
        {
            await _artDbContext.Artworks.AddAsync(artwork);
            await _artDbContext.SaveChangesAsync();
            return artwork;

        }
        //getbyid
        public async Task<Artworks> GetArtworkByIdAsync(int artworkId)
        {
            return await _artDbContext.Artworks.FirstOrDefaultAsync(b => b.ArtworkId == artworkId);
        }


        //UpdateArtwork
        public async Task<Artworks> UpdateArtworkAsync(Artworks artwork)
        {
            var getArt = await GetArtworkByIdAsync(artwork.ArtworkId);
            getArt.ArtworkId = artwork.ArtworkId;
            getArt.CreationDate = artwork.CreationDate;
            getArt.Description = artwork.Description;
            getArt.ImageURL = artwork.ImageURL;
            getArt.ArtistId = artwork.ArtistId;
            getArt.Title = artwork.Title;

            _artDbContext.Artworks.Update(getArt);
           await _artDbContext.SaveChangesAsync();
            return getArt;
        }

        //delete

        public async Task<bool> RemoveArtworkAsync(int artworkId)
        {
            var art = await GetArtworkByIdAsync(artworkId);
            if (art is not null)
            {
                _artDbContext.Artworks.Remove(art);
                return await _artDbContext.SaveChangesAsync() > 0;
            }
            return false;
        }




    }
}
