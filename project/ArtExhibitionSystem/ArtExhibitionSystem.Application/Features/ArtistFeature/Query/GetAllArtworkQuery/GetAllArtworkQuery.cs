using System.Collections;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtworkQuery
{
    public record GetAllArtworkQuery():IRequest<IEnumerable<Artworks>>;
}
