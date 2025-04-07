using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.GalleryFeature.Command.DeleteGallery
{
    public record DeleteGalleryCommand(int galleryId):IRequest<bool>;
}
