using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtworkByIdQuery
{
   
    public class GetArtworkByIdQueryhandler:IRequestHandler<GetArtworkByIdQuery,Artworks>
    {
        readonly IArtworkRepository _artworkRepository;
        public GetArtworkByIdQueryhandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public async Task<Artworks> Handle(GetArtworkByIdQuery request, CancellationToken cancellationToken)
        {
            var findart = await _artworkRepository.GetArtworkByIdAsync(request.artworkId);
            return findart;
        }
    }
}
