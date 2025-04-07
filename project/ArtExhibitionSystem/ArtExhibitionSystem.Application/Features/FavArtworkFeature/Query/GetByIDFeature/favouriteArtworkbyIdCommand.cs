using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Query.GetByIDFeature
{
    public record favouriteArtworkbyIdCommand(int userId) : IRequest<FavoriteArtWork>;
}