using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using MediatR;

namespace ARTExhibition.Application.Features.FavoriteArtWork.Queries.GetAllFavoriteQuery
{
    public class GetFavoriteArtWorksQuery : IRequest<IEnumerable<FavoriteArtWorkResponseDTO>>
    {
        public int UserID { get; set; }

        public GetFavoriteArtWorksQuery(int userId)
        {
            UserID = userId;
        }
    }
}
