using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Commands.DeleteArtistCommand
{
    public class DeleteArtistCommand : IRequest<bool>
    {
        public int ArtistID { get; }

        public DeleteArtistCommand(int artistID)
        {
            ArtistID = artistID;
        }
    }
}
