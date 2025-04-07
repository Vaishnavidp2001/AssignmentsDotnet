using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.FavoriteArtWork.Queries.GetAllFavoriteQuery
{
    public class GetFavoriteArtWorksQueryHandler : IRequestHandler<GetFavoriteArtWorksQuery, IEnumerable<FavoriteArtWorkResponseDTO>>
    {
        private readonly IFavoriteArtWorkRepository _repository;

        public GetFavoriteArtWorksQueryHandler(IFavoriteArtWorkRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FavoriteArtWorkResponseDTO>> Handle(GetFavoriteArtWorksQuery request, CancellationToken cancellationToken)
        {
            // Fetch the favorite artworks for the user
            var favorites = await _repository.GetUserFavoritesAsync(request.UserID);

            // Map the results to DTOs
            var favoriteArtWorksDTO = favorites.Select(f => new FavoriteArtWorkResponseDTO
            {
                UserID = f.UserID,
                ArtworkID = f.ArtworkID,
                ArtworkTitle = "Title Here" // Replace with actual title if available
            });

            return favoriteArtWorksDTO;
        }

        //Task<List<ArtworkDTO>> IRequestHandler<GetFavoriteArtWorksQuery, List<ArtworkDTO>>.Handle(GetFavoriteArtWorksQuery request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
