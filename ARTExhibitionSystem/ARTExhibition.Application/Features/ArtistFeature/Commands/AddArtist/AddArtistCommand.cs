using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.AddArtist
{
    //public record AddArtistCommand(Artist artist) : IRequest<Artist>;
    public record AddArtistCommand(CreateArtistDTO ArtistDTO) : IRequest<int>;

}
