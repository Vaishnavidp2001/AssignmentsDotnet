
using System.Threading.Tasks;
using ARTExhibition.Application.Features.ArtistFeature.Commands;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;
using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Features.ArtistFeature.Commands.AddArtist;

namespace ARTExhibition.Application.Features.ArtistFeature.Handlers
{
    public class AddArtistCommandHandler : IRequestHandler<AddArtistCommand, int>
    {
        private readonly IArtistRepository _artistRepository;

        public AddArtistCommandHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<int> Handle(AddArtistCommand request, CancellationToken cancellationToken)
        {
            var newArtist = new Artist
            {
                Name = request.ArtistDTO.Name,
                Bio = request.ArtistDTO.Bio
            };

            return await _artistRepository.AddArtist(newArtist);
        }
    }
}
