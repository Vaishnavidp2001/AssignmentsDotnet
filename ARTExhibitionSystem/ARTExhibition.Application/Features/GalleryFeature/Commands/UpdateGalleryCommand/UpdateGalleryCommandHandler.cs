using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Features.ArtistFeature.Commands.UpdateArtistCommand;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.UpdateGalleryCommand
{
    public class UpdateGalleryCommandHandler : IRequestHandler<UpdateGalleryCommand, bool>
    {
        private readonly IArtistRepository _artistRepository;

        public UpdateGalleryCommandHandler(IArtistRepository artistRepository)
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

        public Task<bool> Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
