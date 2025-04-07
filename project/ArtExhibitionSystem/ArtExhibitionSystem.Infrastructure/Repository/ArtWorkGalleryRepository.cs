using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Repository
{
    public class ArtWorkGalleryRepository : IArtworkGalleryRepository
    {
        readonly ArtDBContext _artDbContext;
        public ArtWorkGalleryRepository(ArtDBContext  artDbContext)
        {
            _artDbContext= artDbContext;
        }

        //AddArtworkGallery
        public async Task<ArtworkGallery> AddArtworkGallery(ArtworkGallery artworkGallery)
        {
             await _artDbContext.ArtworkGallery.AddAsync(artworkGallery);
            await _artDbContext.SaveChangesAsync();
            return artworkGallery;
        }


        //DeleteArtworkGallery
        public async Task<bool> DeleteArtworkGallery(int artworkId, int galleryId)
        {
             var artgal=await _artDbContext.ArtworkGallery.FirstOrDefaultAsync(b=>b.ArtworkId==artworkId&&b.GalleryId==galleryId);
            if (artgal!=null)
            {
                _artDbContext.ArtworkGallery.Remove(artgal);
                await _artDbContext.SaveChangesAsync();
            }
            return false;
        }
    }
}
