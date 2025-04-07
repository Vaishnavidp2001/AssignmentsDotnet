using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtworkFeature.Commands
{
    public class CreateArtworkCommand :IRequest<Artwork>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int ArtistId { get; set; }
    }



    public class CreateArtworkCommandHandler : IRequestHandler<CreateArtworkCommand, Artwork>
    {
        private readonly IArtworkRepository _artworkRepository;

        public CreateArtworkCommandHandler(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public async Task<Artwork> Handle(CreateArtworkCommand request, CancellationToken cancellationToken)
        {
            var artwork = new Artwork
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
                ArtistID = request.ArtistId
            };

            return await _artworkRepository.AddArtworkAsync(artwork);
        }
    }
}
