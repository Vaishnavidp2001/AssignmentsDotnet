using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ARTExhibition.Application.Features.FavoriteArtWork.Commands.DeleteFavoriteArtWorkCommand
{
    public class DeleteFavoriteArtWorkCommand : IRequest<bool>
    {

        public int UserID { get; set; }
        public int ArtworkID { get; set; }

        public DeleteFavoriteArtWorkCommand(int userId, int artworkId)
        {
            UserID = userId;
            ArtworkID = artworkId;
        }
    }
}
