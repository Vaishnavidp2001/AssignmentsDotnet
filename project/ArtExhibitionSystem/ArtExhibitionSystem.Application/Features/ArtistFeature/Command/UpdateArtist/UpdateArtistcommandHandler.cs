using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtist
{
    public class UpdateArtistcommandHandler:IRequestHandler<UpdateArtistCommand,Artists>
    {
        readonly IArtistsRepository _artistsRepository;
        public UpdateArtistcommandHandler(IArtistsRepository artistsRepository)
        {
            _artistsRepository=artistsRepository;
        }

        public Task<Artists> Handle(UpdateArtistCommand request, CancellationToken cancellationToken)
        {
            var artist = _artistsRepository.UpdateArtist(request.artists);
            return artist;
        }
    }
}
