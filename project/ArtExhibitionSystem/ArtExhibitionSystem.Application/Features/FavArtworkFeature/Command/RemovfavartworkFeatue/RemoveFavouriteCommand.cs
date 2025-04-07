using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command.RemovfavartworkFeatue
{
    public record RemoveFavouriteCommand(int userId):IRequest<bool>;
}
