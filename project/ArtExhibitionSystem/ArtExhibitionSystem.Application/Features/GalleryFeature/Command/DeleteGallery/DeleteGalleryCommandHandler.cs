using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Exceptions;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.GalleryFeature.Command.DeleteGallery
{
    public class DeleteGalleryCommandHandler:IRequestHandler<DeleteGalleryCommand,bool>
    {
        readonly IGalleriesRepository _galleryRepository;
        public DeleteGalleryCommandHandler(IGalleriesRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<bool> Handle(DeleteGalleryCommand request, CancellationToken cancellationToken)
        {
            var deletegallery = await _galleryRepository.RemoveGalleries(request.galleryId);
            if (deletegallery == null) 
            {
                throw new NotFoundException($"artist with Id::{request.galleryId} not found");
            }
            return await _galleryRepository.RemoveGalleries(request.galleryId);
        }
    }
}
