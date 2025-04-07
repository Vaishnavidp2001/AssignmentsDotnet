using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.DTOs;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Commands.AddGallery
{
    public record AddGalleryCommand : IRequest<Gallery>
    {
        public CreateGalleryDTO Gallery { get; } // Use DTO for gallery data

        public AddGalleryCommand(CreateGalleryDTO gallery)
        {
            Gallery = gallery;
        }
    }
}
