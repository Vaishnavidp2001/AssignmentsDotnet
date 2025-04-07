using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class GalleriesRepository : IGalleriesRepository
    {
        readonly ArtDBContext _artDBContext;
        public GalleriesRepository(ArtDBContext artDBContext)
        {
            _artDBContext=artDBContext;
        }

        //GetAllGalleries
        public async Task<IEnumerable<Galleries>> GetAllGalleries()
        {
            return await _artDBContext.Galleries.ToListAsync();
        }

        //AddGalleries
        public async  Task<Galleries> AddGalleries(Galleries galleries)
        {
            await _artDBContext.Galleries.AddAsync(galleries);
            await _artDBContext.SaveChangesAsync();
            return galleries;
        }

        //GetGalleryById
        public async Task<Galleries> GetGalleryById(int galleryId)
        {
            return await _artDBContext.Galleries.FirstOrDefaultAsync(c => c.GalleryId == galleryId);
        }

        //UpdateGallery
        public async Task<Galleries> UpdateGallery(Galleries galleries)
        {
            var updategallery = await GetGalleryById(galleries.GalleryId);

            updategallery.GalleryId = galleries.GalleryId;
            updategallery.Name = galleries.Name;
            updategallery.Description = galleries.Description;
            updategallery.Location = galleries.Location;
            updategallery.ArtistId = galleries.ArtistId;
            
            _artDBContext.Galleries.Update(galleries);
            await _artDBContext.SaveChangesAsync();
            return galleries; 

            }



        //deletegallery
        public async Task<bool> RemoveGalleries(int galleryId)
        {

            var removegallery=await GetGalleryById(galleryId);
            if (removegallery is not null)
            {
                _artDBContext.Galleries.Remove(removegallery);
               return await _artDBContext.SaveChangesAsync()>0;
            }
            return false;
        }
    }
}
