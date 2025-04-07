using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Queries.GetAllGalleryQuery
{
    public class GetGalleryQueryHandler : IRequestHandler<GetGalleryQuery, IEnumerable<Gallery>>
    {
        private readonly IGalleryRepository _galleryRepository;

        public GetGalleryQueryHandler(IGalleryRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<IEnumerable<Gallery>> Handle(GetGalleryQuery request, CancellationToken cancellationToken)
        {
            return await _galleryRepository.GetAllGalleriesAsync();
        }
    }
}
