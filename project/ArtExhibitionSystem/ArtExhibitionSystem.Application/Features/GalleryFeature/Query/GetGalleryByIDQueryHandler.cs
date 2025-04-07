 
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllGalleries;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.GalleryFeature.Query
{
    public class GetGalleryByIDQueryHandler:IRequestHandler<GetGalleryByIDQuery, Galleries>
    {
        readonly IGalleriesRepository _galleryRepository;
        public GetGalleryByIDQueryHandler(IGalleriesRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

         public async Task<Galleries> Handle(GetGalleryByIDQuery request, CancellationToken cancellationToken)
        {
            var gallery = await _galleryRepository.GetGalleryById(request.galleryId);
            return gallery;
        }
    }
}
