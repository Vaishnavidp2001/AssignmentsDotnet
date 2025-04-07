using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;

namespace ARTExhibition.Application.Interfaces
{
    public interface IArtworkGalleryRepository
    {
        Task<IEnumerable<ArtworkGallery>> GetArtworksInGalleryAsync(int galleryId);
        Task AddArtworkToGalleryAsync(ArtworkGallery artworkGallery);
        Task RemoveArtworkFromGalleryAsync(int artworkId, int galleryId);
    }
}
