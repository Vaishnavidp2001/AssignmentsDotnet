using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtworkFeature.Queries.GetAllArtworksQuery
{
    public class GetArtworkQuery : IRequest<IEnumerable<Artwork>> { }

    public class GetArtworkQueryHandler : IRequestHandler<GetArtworkQuery, IEnumerable<Artwork>>
    {
        private readonly IArtworkRepository _artworkRepository;

        public GetArtworkQueryHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public async Task<IEnumerable<Artwork>> Handle(GetArtworkQuery request, CancellationToken cancellationToken)
        {
            return await _artworkRepository.GetAllArtworksAsync();
        }
    }




}
