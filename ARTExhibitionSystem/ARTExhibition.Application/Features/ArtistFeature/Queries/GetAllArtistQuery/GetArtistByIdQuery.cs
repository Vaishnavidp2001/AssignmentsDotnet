using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery
{
    public class GetArtistByIdQuery : IRequest<ArtistDTO>
    {
        public int ArtistId { get; }

        public GetArtistByIdQuery(int artistId)
        {
            ArtistId = artistId;
        }
    }
}
