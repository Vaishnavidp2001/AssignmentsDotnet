using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtworkQuery
{
    public class GetAllArtworkQueryHandler : IRequestHandler<GetAllArtworkQuery, IEnumerable<Artworks>>
    {
        readonly  IArtworkRepository _artworkRepository;

        public GetAllArtworkQueryHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }
        public async Task<IEnumerable<Artworks>> Handle(GetAllArtworkQuery request, CancellationToken cancellationToken)
        {
           var allArtists= await _artworkRepository.GetAllArtwork();
            return allArtists;
        }


    }
}
