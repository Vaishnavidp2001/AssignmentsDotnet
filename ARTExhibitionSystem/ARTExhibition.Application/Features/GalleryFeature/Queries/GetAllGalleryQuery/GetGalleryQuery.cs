using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.GalleryFeature.Queries.GetAllGalleryQuery
{

    // Query record to retrieve all galleries
    public record GetGalleryQuery() : IRequest<IEnumerable<Gallery>>;
}
