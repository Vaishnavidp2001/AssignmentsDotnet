
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Exceptions;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.DeleteFeature
{
    public class DeleteArtworkGalleryCommandHandler:IRequestHandler<DeleteArtworkGalleryCommand,bool>
    {
        readonly IArtworkGalleryRepository _artworkGalleryRepository;
        public DeleteArtworkGalleryCommandHandler(IArtworkGalleryRepository artworkGalleryRepository)
        {
            _artworkGalleryRepository=artworkGalleryRepository;
        }

        public async Task<bool> Handle(DeleteArtworkGalleryCommand request, CancellationToken cancellationToken)
        {
            var delartgal = await _artworkGalleryRepository.DeleteArtworkGallery(request.artworkId, request.galleryId);
            if (delartgal==null)
            {
                throw new NotFoundException($"artist with Id::{request.galleryId}& ,{request.artworkId}not found");
            }
            return await _artworkGalleryRepository.DeleteArtworkGallery(request.artworkId, request.galleryId);

        }
    }
}
