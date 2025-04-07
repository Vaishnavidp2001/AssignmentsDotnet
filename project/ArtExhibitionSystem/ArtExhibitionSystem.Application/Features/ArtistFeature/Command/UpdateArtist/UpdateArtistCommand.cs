using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtist
{
    public record UpdateArtistCommand(Artists artists):IRequest<Artists>;
    
}
