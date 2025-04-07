using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ARTExhibition.Application.Interfaces;

namespace ARTExhibitionSystem.Infrastructure.Repositories;

public class ArtworkGalleryRepository : IArtworkGalleryRepository
{
    private readonly ApplicationDbContext _context;

    public ArtworkGalleryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ArtworkGallery>> GetArtworksInGalleryAsync(int galleryId)
    {
        return await _context.ArtworkGalleries
            .Where(ag => ag.GalleryID == galleryId)
            .ToListAsync();
    }

    public async Task AddArtworkToGalleryAsync(ArtworkGallery artworkGallery)
    {
        await _context.ArtworkGalleries.AddAsync(artworkGallery);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveArtworkFromGalleryAsync(int artworkId, int galleryId)
    {
        var artworkGallery = await _context.ArtworkGalleries
            .FirstOrDefaultAsync(ag => ag.ArtworkID == artworkId && ag.GalleryID == galleryId);
        if (artworkGallery != null)
        {
            _context.ArtworkGalleries.Remove(artworkGallery);
            await _context.SaveChangesAsync();
        }
    }
}
