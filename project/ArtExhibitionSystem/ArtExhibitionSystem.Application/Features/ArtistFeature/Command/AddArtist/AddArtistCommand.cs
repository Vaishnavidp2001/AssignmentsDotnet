using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtist
{
    public record AddArtistCommand(Artists artistId) :IRequest<Artists>;
     
}
