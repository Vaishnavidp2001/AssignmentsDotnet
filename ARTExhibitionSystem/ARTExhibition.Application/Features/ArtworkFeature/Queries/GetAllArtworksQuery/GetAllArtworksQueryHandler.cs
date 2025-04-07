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
    public class GetAllArtworksQueryHandler : IRequestHandler<GetArtworkQuery, IEnumerable<Artwork>>
    {
        private readonly IArtworkRepository _artworkRepository;

        public GetAllArtworksQueryHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public Task<IEnumerable<Artwork>> Handle(GetArtworkQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            return  _artworkRepository.GetAllArtworksAsync();
        }

        
    }
}
