using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Exceptions;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.RemoveArtwork
{
    public class RemoveArtworkCommandHandler:IRequestHandler<RemoveArtworkCommand, bool>
    {
        readonly IArtworkRepository _artworkRepository;
        public RemoveArtworkCommandHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;

        }

        public async Task<bool> Handle(RemoveArtworkCommand request, CancellationToken cancellationToken)   
        {
           var artworkFind = await _artworkRepository.RemoveArtworkAsync(request.artworkId);

            if (artworkFind == null)
            {
                throw new NotFoundException($"artwork with Id::{request.artworkId} not found");

            }
            return await _artworkRepository.RemoveArtworkAsync(request.artworkId);
        }
    }
}
