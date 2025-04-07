using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtists
{
   
    public class GetAllArtistsQueryHandler:IRequestHandler<GetAllArtistsQuery ,IEnumerable<Artists>>
    {
        readonly IArtistsRepository _artistsRepository;
        public GetAllArtistsQueryHandler(IArtistsRepository artistsRepository)
        {
            _artistsRepository = artistsRepository;
        }

        public async Task<IEnumerable<Artists>> Handle(GetAllArtistsQuery request, CancellationToken cancellationToken)
        {
             var getAllartists= await _artistsRepository.GetAllArtists();
            return getAllartists;
        }
    }
}
