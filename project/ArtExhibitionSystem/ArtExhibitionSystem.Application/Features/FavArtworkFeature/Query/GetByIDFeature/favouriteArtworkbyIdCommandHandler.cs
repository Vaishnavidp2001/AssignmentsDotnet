using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Query.GetByIDFeature
{
    public class favouriteArtworkbyIdCommandHandler : IRequestHandler<favouriteArtworkbyIdCommand, FavoriteArtWork>
    {
        readonly IFavoriteArtWorkRepository _favoriteArtWorkRepository;
        public favouriteArtworkbyIdCommandHandler(IFavoriteArtWorkRepository favoriteArtWorkRepository)
        {
            _favoriteArtWorkRepository=favoriteArtWorkRepository;
        }
        public async Task<FavoriteArtWork> Handle(favouriteArtworkbyIdCommand request, CancellationToken cancellationToken)
        {
            var favid = await _favoriteArtWorkRepository.GetFavoriteArtWorkById(request.userId);
            return favid;
        }
    }
}
