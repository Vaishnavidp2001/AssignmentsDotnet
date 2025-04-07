using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.DeleteFeature
{
    public record DeleteArtworkGalleryCommand(int artworkId,int galleryId):IRequest<bool>;
}
