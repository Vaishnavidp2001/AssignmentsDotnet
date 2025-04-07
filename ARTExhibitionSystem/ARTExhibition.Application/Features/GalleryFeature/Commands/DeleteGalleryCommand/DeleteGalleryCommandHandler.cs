using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Features.ArtistFeature.Commands.DeleteArtistCommand;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.DeleteGalleryCommand
{
    internal class DeleteGalleryCommandHandler : IRequestHandler<DeleteGalleryCommand, bool>
    {
        private readonly IArtistRepository _artistRepository;

        public DeleteGalleryCommandHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<bool> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        {
            return await _artistRepository.DeleteArtistAsync(request.ArtistID);
        }

        public Task<bool> Handle(DeleteGalleryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
