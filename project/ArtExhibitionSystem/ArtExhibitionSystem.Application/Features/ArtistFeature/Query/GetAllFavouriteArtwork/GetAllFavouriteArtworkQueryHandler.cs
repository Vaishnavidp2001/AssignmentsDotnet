using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllFavouriteArtwork
{
    public class GetAllFavouriteArtworkQueryHandler:IRequestHandler<GetAllFavouriteArtworkQuery ,IEnumerable<FavoriteArtWork>>
    {
        readonly IFavoriteArtWorkRepository _favoriteArtWorkRepository;
        public GetAllFavouriteArtworkQueryHandler(IFavoriteArtWorkRepository favoriteArtWorkRepository)
        {
            _favoriteArtWorkRepository = favoriteArtWorkRepository;
        }



        public async Task<IEnumerable<FavoriteArtWork>> Handle(GetAllFavouriteArtworkQuery request, CancellationToken cancellationToken)
        {
            var allfav = await _favoriteArtWorkRepository.GetAllFavoriteArtwork();
            return allfav;
        }
    }
}
