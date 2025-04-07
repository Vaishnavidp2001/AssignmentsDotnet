using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtwork
{   
        public record AddArtworkCommand( Artworks artworkId) : IRequest<Artworks>;
   

}
