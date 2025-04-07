using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery
{
    public class GetArtistByIdHandler : IRequestHandler<GetArtistByIdQuery, ArtistDTO>
    {
        private readonly IArtistRepository _artistRepository;

        public GetArtistByIdHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<ArtistDTO> Handle(GetArtistByIdQuery request, CancellationToken cancellationToken)
        {
            var artist = await _artistRepository.GetArtistByIdAsync(request.ArtistId);
            if (artist == null) return null;

            return new ArtistDTO
            {
                ArtistID = artist.ArtistID,
                Name = artist.Name,
                Bio = artist.Bio
            };

        }
    }
}
