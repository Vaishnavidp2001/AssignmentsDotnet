using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtworkByIdQuery
{
    public record GetArtworkByIdQuery(int artworkId):IRequest<Artworks>;
}
