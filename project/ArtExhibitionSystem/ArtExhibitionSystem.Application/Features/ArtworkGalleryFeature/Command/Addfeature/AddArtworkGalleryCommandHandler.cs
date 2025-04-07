using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.Addfeature
{
    public class AddArtworkGalleryCommandHandler:IRequestHandler<AddArtworkGalleryCommand, ArtworkGallery>
    {
        readonly IArtworkGalleryRepository _artworkGalleryRepository;
        public AddArtworkGalleryCommandHandler(IArtworkGalleryRepository artworkGalleryRepository)
        {
            _artworkGalleryRepository=artworkGalleryRepository;

        }

        public async Task<ArtworkGallery> Handle(AddArtworkGalleryCommand request, CancellationToken cancellationToken)
        {
            var addartgal = await _artworkGalleryRepository.AddArtworkGallery(request.artworkGallery);
            return addartgal;
        }
    }
}
