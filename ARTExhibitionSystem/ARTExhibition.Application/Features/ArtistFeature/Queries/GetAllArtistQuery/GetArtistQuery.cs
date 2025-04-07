using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;

namespace ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery
{
    public record GetArtistQuery() : IRequest<IEnumerable<Artist>>;
}
