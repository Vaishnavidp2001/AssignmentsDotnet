using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.DeleteGalleryCommand
{
    public class DeleteGalleryCommand : IRequest<bool>
    {
        public int ArtistID { get; }

        public DeleteGalleryCommand(int artistID)
        {
            ArtistID = artistID;
        }
    }
}
