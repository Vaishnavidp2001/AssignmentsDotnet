using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Context;
using ARTExhibition.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ARTExhibitionSystem.Infrastructure.Repositories;

public class GalleryRepository : IGalleryRepository
{
    private readonly ApplicationDbContext _context;

    public GalleryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Gallery>> GetAllGalleriesAsync()
    {
        return await _context.Galleries.ToListAsync();
    }

    public async Task<Gallery> GetGalleryByIdAsync(int id)
    {
        return await _context.Galleries.FindAsync(id);
    }

    public async Task<Gallery> AddGalleryAsync(Gallery gallery)
    {
        await _context.Galleries.AddAsync(gallery);
        await _context.SaveChangesAsync();
        return gallery;
    }

    public async Task UpdateGalleryAsync(Gallery gallery)
    {
        _context.Galleries.Update(gallery);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGalleryAsync(int id)
    {
        var gallery = await _context.Galleries.FindAsync(id);
        if (gallery != null)
        {
            _context.Galleries.Remove(gallery);
            await _context.SaveChangesAsync();
        }
    }

}
