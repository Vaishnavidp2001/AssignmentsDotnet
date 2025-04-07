using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllFavouriteArtwork
{
    public record GetAllFavouriteArtworkQuery: IRequest<IEnumerable<FavoriteArtWork>>;
   
}
