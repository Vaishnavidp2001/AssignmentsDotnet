using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtistById
{
    
    public class GetArtistByIdQueryHandler:IRequestHandler<GetArtistByIdQuery, Artists>
    {
        readonly IArtistsRepository _artistsRepository;
        public GetArtistByIdQueryHandler(IArtistsRepository artistsRepository)
        {
            _artistsRepository = artistsRepository;
        }

        public async Task<Artists> Handle(GetArtistByIdQuery request, CancellationToken cancellationToken)
        {
            var getArtist = await _artistsRepository.GetArtistById(request.artistId);
                return getArtist;
        }
    }
}
