using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.UpdateArtistCommand
{
    public class UpdateArtistCommand : IRequest<bool>
    {
        public UpdateArtistDTO ArtistDto { get; }

        public UpdateArtistCommand(UpdateArtistDTO artistDto)
        {
            ArtistDto = artistDto;
        }
    }
}
