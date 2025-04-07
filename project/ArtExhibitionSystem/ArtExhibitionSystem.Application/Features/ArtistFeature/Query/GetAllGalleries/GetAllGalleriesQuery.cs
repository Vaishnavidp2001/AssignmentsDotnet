using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllGalleries
{
    public record GetAllGalleriesQuery() : IRequest<IEnumerable<Galleries>>;
}
