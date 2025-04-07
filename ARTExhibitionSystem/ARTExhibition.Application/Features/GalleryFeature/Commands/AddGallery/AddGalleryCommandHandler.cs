using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.AddGallery
{
    public class AddGalleryCommandHandler : IRequestHandler<AddGalleryCommand, Gallery>
    {
        //private readonly IGalleryRepository _galleryRepository;

        //public AddGalleryCommandHandler(IGalleryRepository galleryRepository)
        //{
        //    _galleryRepository = galleryRepository;
        //}

        //public async Task<Gallery> Handle(AddGalleryCommand request, CancellationToken cancellationToken)
        //{
        //    // Delegate to the repository to add the gallery
        //    return await _galleryRepository.AddGalleryAsync(request.gallery);
        //}

        private readonly IGalleryRepository _galleryRepository;

        public AddGalleryCommandHandler(IGalleryRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<Gallery> Handle(AddGalleryCommand request, CancellationToken cancellationToken)
        {
            // Create a new Gallery entity from the DTO
            var newGallery = new Gallery
            {
                // Map properties from the DTO to the entity
                ArtistId=request.Gallery.ArtistID,
                Name = request.Gallery.Name,
                Description = request.Gallery.Description,
                Location = request.Gallery.Location
                // Add other properties as needed
            };

            // Delegate to the repository to add the gallery
            return await _galleryRepository.AddGalleryAsync(newGallery);
        }
    }
}
