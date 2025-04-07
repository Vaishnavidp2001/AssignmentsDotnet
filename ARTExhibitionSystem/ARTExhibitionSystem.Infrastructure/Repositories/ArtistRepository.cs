using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ARTExhibitionSystem.Infrastructure.Repositories;

public class ArtistRepository : IArtistRepository
{
    private readonly ApplicationDbContext _context;

    public ArtistRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Artist>> GetAllArtistsAsync()
    {
        return await _context.Artists.ToListAsync();
    }

    public async Task<Artist?> GetArtistByIdAsync(int artistId)
    {
        return await _context.Artists.FindAsync(artistId);
    }

    public async Task<int> AddArtist(Artist artist)
    {
        await _context.Artists.AddAsync(artist);
        //_context.Artists.AddAsync(artist);
        await _context.SaveChangesAsync();
       // return artist;
        return artist.ArtistID;
    }

    public async Task UpdateArtistAsync(Artist artist)
    {
        _context.Artists.Update(artist);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> DeleteArtistAsync(int artistId)
    {
        //var artist = await _context.Artists.FindAsync(artistId);
        //if (artist != null)
        //{
        //    _context.Artists.Remove(artist);
        //    await _context.SaveChangesAsync();
        //}

        var artist = await _context.Artists.FindAsync(artistId);
        if (artist == null) return false;

        _context.Artists.Remove(artist);
        await _context.SaveChangesAsync();
        return true; // Return true when deletion is successful
    }

    //Task<int> IArtistRepository.AddArtist(Artist artist)
    //{
    //    throw new NotImplementedException();
    //}
}
