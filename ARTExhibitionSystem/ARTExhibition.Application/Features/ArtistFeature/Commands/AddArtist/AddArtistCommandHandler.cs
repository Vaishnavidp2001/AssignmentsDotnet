//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ARTExhibition.Application.Interfaces;
//using ARTExhibitionSystem.Domain.Entities;
//using MediatR;
//using System.Threading;
//using System.Threading.Tasks;
//using ARTExhibition.Application.DTOs;

//namespace ARTExhibition.Application.Features.ArtistFeature.Commands.AddArtist
//{
//    public class AddArtistCommandHandler : IRequestHandler<AddArtistCommand, int>
//    {
//        private readonly IArtistRepository _artistRepository;

//        public AddArtistCommandHandler(IArtistRepository artistRepository)
//        {
//            _artistRepository = artistRepository;
//        }

//        public async Task<Artist> Handle(AddArtistCommand request, CancellationToken cancellationToken)
//        {
//            // Add the new artist via repository
//            //return await _artistRepository.AddArtist(request.artist);

//            var newArtist = new Artist
//            {
//                Name = request.ArtistDTO.Name,
//                Bio = request.ArtistDTO.Bio
//            };

//            return await _artistRepository.AddArtist(newArtist);
//        }
//    }
//}

using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.AddArtist
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

            //await _artistRepository.AddArtist(newArtist);

            //return newArtist.ArtistID;  // Return ID instead of Artist

            int artistId = await _artistRepository.AddArtist(newArtist);  // Store the returned ID
            return artistId;  // Return the ID instead of the entire object
        }
    }
}
