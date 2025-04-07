using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.UpdateGalleryCommand
{
    public class UpdateGalleryCommand : IRequest<bool>
    {
        public UpdateGalleryDTO Gallery { get; }

        public UpdateGalleryCommand(UpdateGalleryDTO gallery)
        {
            Gallery = gallery;
        }
    }
}
