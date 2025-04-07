using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery
{
    public class GetArtistQueryHandler : IRequestHandler<GetArtistQuery, IEnumerable<Artist>>
    {
        private readonly IArtistRepository _artistRepository;

        public GetArtistQueryHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<IEnumerable<Artist>> Handle(GetArtistQuery request, CancellationToken cancellationToken)
        {
            return await _artistRepository.GetAllArtistsAsync();
        }
    }
}
