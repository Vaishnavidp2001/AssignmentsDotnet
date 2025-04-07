using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.FavoriteArtWork.Commands.AddFavotiteArtWork
{
    public class AddFavoriteArtWorkCommandHandler : IRequestHandler<AddFavoriteArtWorkCommand, bool>
    {
        private readonly IFavoriteArtWorkRepository _repository;

        public AddFavoriteArtWorkCommandHandler(IFavoriteArtWorkRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(AddFavoriteArtWorkCommand request, CancellationToken cancellationToken)
        {
            // Implement logic to add favorite artwork
            //return await _repository.AddFavoriteArtWorkAsync(request.UserID, request.ArtworkID);
            await _repository.AddFavoriteArtWorkAsync(request.UserID, request.ArtworkID);
            return true; // Return true if the operation was successful
        }
    }
}
