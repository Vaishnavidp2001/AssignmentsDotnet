using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtist
{
    public class AddArtistCommandHandler:IRequestHandler<AddArtistCommand, Artists>
    {
        readonly IArtistsRepository _artistsRepository;
        public AddArtistCommandHandler(IArtistsRepository artistsRepository)
        {
            _artistsRepository = artistsRepository;
        }

        public async Task<Artists> Handle(AddArtistCommand request, CancellationToken cancellationToken)
        {
            var addartist = await _artistsRepository.AddArtists(request.artistId);
            return addartist;
        }
    }
}
