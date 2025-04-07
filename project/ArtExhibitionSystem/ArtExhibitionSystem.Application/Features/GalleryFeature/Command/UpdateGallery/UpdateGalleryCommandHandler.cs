using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.GalleryFeature.Command.UpdateGallery
{
    public class UpdateGalleryCommandHandler:IRequestHandler<UpdateGalleryCommand,Galleries>
    {
        readonly IGalleriesRepository _galleriesRepository;
        public UpdateGalleryCommandHandler(IGalleriesRepository galleriesRepository)
        {
            _galleriesRepository= galleriesRepository;
        }

        public async Task<Galleries> Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {
             var updateGallery=await _galleriesRepository.UpdateGallery(request.galleries);
            return updateGallery;
        }
    }
}
