using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Exceptions;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.DeleteArtist
{
    public class DeleteArtistCommandHandler:IRequestHandler<DeleteArtistCommand,bool>
    {
        readonly IArtistsRepository _artistsRepository;
        public DeleteArtistCommandHandler(IArtistsRepository artistsRepository)
        {
            _artistsRepository = artistsRepository;
        }

        public async Task<bool> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        {
            var artistfind = await _artistsRepository.DeleteArtist(request.artistId);
            if (artistfind==null)
            {
               throw new  NotFoundException($"artist with Id::{request.artistId} not found");
            }
            return await _artistsRepository.DeleteArtist(request.artistId);
        }

       

    }
            
}

