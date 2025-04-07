using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtists
{
    public record GetAllArtistsQuery: IRequest<IEnumerable<Artists>>;
   
}
