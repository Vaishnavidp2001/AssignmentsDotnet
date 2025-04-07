 
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllGalleries
{
    public class GetAllGalleriesQueryHandler:IRequestHandler<GetAllGalleriesQuery,IEnumerable<Galleries>>
    {
        readonly IGalleriesRepository _galleriesRepository;
        public GetAllGalleriesQueryHandler(IGalleriesRepository galleriesRepository)
        {
            _galleriesRepository= galleriesRepository;
        }

        public  async Task<IEnumerable<Galleries>> Handle(GetAllGalleriesQuery request, CancellationToken cancellationToken)
        {
            var allgalleries =await  _galleriesRepository.GetAllGalleries();
            return allgalleries;
        }
    }
}
