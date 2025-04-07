using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.Addfeature
{
    public record AddArtworkGalleryCommand(ArtworkGallery artworkGallery):IRequest<ArtworkGallery>;
}
