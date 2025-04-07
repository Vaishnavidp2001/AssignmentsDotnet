using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command
{
    public record FavouriteArtworkCommand(int userId, int artworkId) : IRequest<FavoriteArtWork>;

}
