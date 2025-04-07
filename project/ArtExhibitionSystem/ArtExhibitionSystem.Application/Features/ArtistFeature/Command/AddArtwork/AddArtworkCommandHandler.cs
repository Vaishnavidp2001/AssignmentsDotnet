using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtwork
{
    public class AddArtworkCommandHandler:IRequestHandler<AddArtworkCommand,Artworks>
    {
        readonly IArtworkRepository _artworkRepository;
        public AddArtworkCommandHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public Task<Artworks> Handle(AddArtworkCommand request, CancellationToken cancellationToken)
        {
            var artworks = _artworkRepository.AddArtworkAsync(request.artworkId);
            return artworks;
        }
    }
}
