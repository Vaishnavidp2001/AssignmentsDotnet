using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtworkFeature.Commands.AddArtwork
{
    public record AddArtworkCommand(Artwork artwork) : IRequest<Artwork>;

}
