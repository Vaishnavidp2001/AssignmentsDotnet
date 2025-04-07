using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddGalleries
{
    public class AddGalleriesCommandHandler:IRequestHandler<AddGalleriesCommand,Galleries>
    {
        readonly IGalleriesRepository _galleriesRepository;
        public AddGalleriesCommandHandler(IGalleriesRepository galleriesRepository)
        {
            _galleriesRepository = galleriesRepository;
        }

        public async Task<Galleries> Handle(AddGalleriesCommand request, CancellationToken cancellationToken)
        {
            var galleries = await _galleriesRepository.AddGalleries(request.galleryId);
            return galleries;
        }
    }
}
