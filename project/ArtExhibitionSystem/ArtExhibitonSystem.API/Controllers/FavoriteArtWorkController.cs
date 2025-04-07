using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllFavouriteArtwork;
using ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command;
using ArtExhibitionSystem.Application.Features.FavArtworkFeature.Command.RemovfavartworkFeatue;
using ArtExhibitionSystem.Application.Features.FavArtworkFeature.Query.GetByIDFeature;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteArtWorkController : ControllerBase
    {
        readonly IMediator _mediatoR;

        public FavoriteArtWorkController(IMediator mediator)
        {
            _mediatoR = mediator;
        }

        //GetAllFavoriteArtwork
        [HttpGet]
        public async Task<IActionResult> GetAllFavoriteArtwork()
        { 
            var result= await _mediatoR.Send(new GetAllFavouriteArtworkQuery());
            return Ok(result);
        }

        //AddArtworkToFavorite
        [HttpPut]
        public async Task<IActionResult> AddArtworkToFavorite(int userId, int artworkId)
        {
            var result = await _mediatoR.Send(new FavouriteArtworkCommand(userId, artworkId));
            return Ok(result);

        }

        //GetFavoriteArtWorkById

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetFavoriteArtWorkById(int userId)
        {
            var result = await _mediatoR.Send(new favouriteArtworkbyIdCommand(userId));
            return Ok(result);

        }

        //RemoveArtworkFromFavorite
        [HttpDelete]
        public async Task<IActionResult> RemoveArtworkFromFavorite(int userId)
        {
            var result = await _mediatoR.Send(new RemoveFavouriteCommand(userId));
            return Ok(result);
        }

    }
}
