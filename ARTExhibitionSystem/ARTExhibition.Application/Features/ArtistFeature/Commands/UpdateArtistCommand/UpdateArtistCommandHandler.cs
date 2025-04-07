using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.UpdateArtistCommand
{
    public class UpdateArtistCommandHandler : IRequestHandler<UpdateArtistCommand, bool>
    {
        private readonly IArtistRepository _artistRepository;

        public UpdateArtistCommandHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<bool> Handle(UpdateArtistCommand request, CancellationToken cancellationToken)
        {
            var artist = await _artistRepository.GetArtistByIdAsync(request.ArtistDto.ArtistID);
            if (artist == null) return false;

            artist.Name = request.ArtistDto.Name;
            artist.Bio = request.ArtistDto.Bio;

            await _artistRepository.UpdateArtistAsync(artist);
            return true;
        }
    }
}
