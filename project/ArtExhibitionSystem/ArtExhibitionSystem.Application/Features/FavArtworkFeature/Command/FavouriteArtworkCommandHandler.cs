using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command
{
    public class FavouriteArtworkCommandHandler : IRequestHandler<FavouriteArtworkCommand, FavoriteArtWork>
    {
        readonly IFavoriteArtWorkRepository _favArtWorkRepository;
        public FavouriteArtworkCommandHandler(IFavoriteArtWorkRepository favArtWorkRepository)
        {
            _favArtWorkRepository = favArtWorkRepository;
        }
        public async Task<FavoriteArtWork> Handle(FavouriteArtworkCommand request, CancellationToken cancellationToken)
        {
            var favart = await _favArtWorkRepository.AddArtworkToFavorite(request.artworkId, request.userId);
            return favart;
        }
    }
}
