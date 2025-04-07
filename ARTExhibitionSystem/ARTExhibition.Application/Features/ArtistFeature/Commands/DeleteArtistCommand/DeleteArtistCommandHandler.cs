using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.DeleteArtistCommand
{
    public class DeleteArtistCommandHandler : IRequestHandler<DeleteArtistCommand, bool>
    {
        private readonly IArtistRepository _artistRepository;

        public DeleteArtistCommandHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<bool> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        {
            return await _artistRepository.DeleteArtistAsync(request.ArtistID);
        }
    }
}
