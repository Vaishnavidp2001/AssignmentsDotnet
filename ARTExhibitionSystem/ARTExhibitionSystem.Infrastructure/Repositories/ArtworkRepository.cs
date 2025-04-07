using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ARTExhibition.Application.Interfaces;


namespace ARTExhibitionSystem.Infrastructure.Repositories;

public class ArtworkRepository : IArtworkRepository
{
    private readonly ApplicationDbContext _context;

    public ArtworkRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Artwork>> GetAllArtworksAsync()
    {
        return await _context.Artworks.ToListAsync();
    }

    public async Task<Artwork?> GetArtworkByIdAsync(int artworkId)
    {
        return await _context.Artworks.FindAsync(artworkId);
    }

    public async Task<Artwork> AddArtworkAsync(Artwork artwork)
    {
        await _context.Artworks.AddAsync(artwork);
        await _context.SaveChangesAsync();
        return artwork;
    }

    public async Task UpdateArtworkAsync(Artwork artwork)
    {
        _context.Artworks.Update(artwork);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> DeleteArtworkAsync(int artworkId)
    {
        var artwork = await _context.Artworks.FindAsync(artworkId);
        if (artwork != null)
        {
            _context.Artworks.Remove(artwork);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;

    }
}


