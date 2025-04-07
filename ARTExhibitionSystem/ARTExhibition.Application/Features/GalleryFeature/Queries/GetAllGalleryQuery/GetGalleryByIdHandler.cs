using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Queries.GetAllGalleryQuery
{
    public class GetGalleryByIdHandler : IRequestHandler<GetGalleryByIdQuery, GalleryDTO>
    {
        private readonly IGalleryRepository _galleryRepository;

        public GetGalleryByIdHandler(IGalleryRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<GalleryDTO> Handle(GetGalleryByIdQuery request, CancellationToken cancellationToken)
        {
            var gallery = await _galleryRepository.GetGalleryByIdAsync(request.GalleryId);
            if (gallery == null) return null;

            return new GalleryDTO
            {
                GalleryID = gallery.GalleryID,
                Name = gallery.Name,
                Description = gallery.Description,
                Location = gallery.Location,
                ArtistID = gallery.ArtistId
            };
        }
    }
}
