using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class ArtistsRepository: IArtistsRepository
    {
        readonly ArtDBContext  _artDbContext;

        public ArtistsRepository(ArtDBContext artDbContext)
        {
            _artDbContext=artDbContext; 
        }

       //getallartists
        public async Task<IEnumerable<Artists>>GetAllArtists()
        {
            return await _artDbContext.Artists.ToListAsync();
        }

        //AddArtists
        public async Task<Artists> AddArtists(Artists artist)
        {
            await _artDbContext.Artists.AddAsync(artist);
            await _artDbContext.SaveChangesAsync();
            return artist;
        }

        //GetArtistById
        public async Task<Artists> GetArtistById(int artistId)
        {
            return await _artDbContext.Artists.FirstOrDefaultAsync(c=>c.ArtistID==artistId);         
        }

        //UpdateArtist
        public async Task<Artists> UpdateArtist(Artists artists)
        {
            var getArtist = await GetArtistById(artists.ArtistID);
            getArtist.ArtistPhone=artists.ArtistPhone;
            getArtist.ArtistID=artists.ArtistID;
            getArtist.ArtistBirthdate=artists.ArtistBirthdate;
            getArtist.ArtistName=artists.ArtistName;

            _artDbContext.Artists.Update(getArtist);
            await _artDbContext.SaveChangesAsync();
            return artists;
        }

        //DeleteArtist
        public async Task<bool> DeleteArtist(int artistId)
        {
            var del = await GetArtistById(artistId);
            if (del is not null)
            {
                _artDbContext.Artists.Remove(del);
                return await _artDbContext.SaveChangesAsync() > 0;
            }
            return false;
        }
        
    }
}
