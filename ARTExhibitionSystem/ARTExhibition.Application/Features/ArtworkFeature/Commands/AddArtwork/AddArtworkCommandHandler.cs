using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;
using ARTExhibitionSystem.Domain;

namespace ARTExhibition.Application.Features.ArtworkFeature.Commands.AddArtwork
{
    public class AddArtworkCommandHandler : IRequestHandler<AddArtworkCommand, Artwork>
    {
        private readonly IArtworkRepository _artworkRepository;

        public AddArtworkCommandHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public async Task<Artwork> Handle(AddArtworkCommand request, CancellationToken cancellationToken)
        {
            // Delegate to the repository to add the artwork
            return await _artworkRepository.AddArtworkAsync(request.artwork);
        }
    }
}
