using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Queries.GetAllGalleryQuery
{
    public class GetGalleryByIdQuery : IRequest<GalleryDTO>
    {
        public int GalleryId { get; }

        public GetGalleryByIdQuery(int galleryId)
        {
            GalleryId = galleryId;
        }
    }
}
