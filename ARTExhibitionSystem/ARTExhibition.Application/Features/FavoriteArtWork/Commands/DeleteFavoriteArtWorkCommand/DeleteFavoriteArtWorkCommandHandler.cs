using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using MediatR;

namespace ARTExhibition.Application.Features.FavoriteArtWork.Commands.DeleteFavoriteArtWorkCommand
{
    public class DeleteFavoriteArtWorkCommandHandler : IRequestHandler<DeleteFavoriteArtWorkCommand, bool>
    {
        private readonly IFavoriteArtWorkRepository _repository;

        public DeleteFavoriteArtWorkCommandHandler(IFavoriteArtWorkRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteFavoriteArtWorkCommand request, CancellationToken cancellationToken)
        {
            // Implement logic to delete favorite artwork
            return await _repository.DeleteFavoriteArtWorkAsync(request.UserID, request.ArtworkID);
        }
    }
}
