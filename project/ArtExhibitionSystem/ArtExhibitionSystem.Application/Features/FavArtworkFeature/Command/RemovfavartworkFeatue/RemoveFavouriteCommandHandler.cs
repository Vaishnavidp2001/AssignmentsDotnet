using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Exceptions;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command.RemovfavartworkFeatue
{
    public class RemoveFavouriteCommandHandler:IRequestHandler<RemoveFavouriteCommand, bool>
    {
        readonly IFavoriteArtWorkRepository _favoriteArtWorkRepository;
        public RemoveFavouriteCommandHandler(IFavoriteArtWorkRepository favoriteArtWorkRepository)
        {
            _favoriteArtWorkRepository=favoriteArtWorkRepository;
        }

        public async Task<bool> Handle(RemoveFavouriteCommand request, CancellationToken cancellationToken)
        {
            var removfav = await _favoriteArtWorkRepository.RemoveArtworkFromFavorite(request.userId);
            if (removfav==null)
            {
                throw new NotFoundException($"artist with Id::{request.userId} not found");

            }
            return await _favoriteArtWorkRepository.RemoveArtworkFromFavorite(request.userId);
        }
    }
}
