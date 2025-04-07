using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Features.FavoriteArtWork.Commands.AddFavotiteArtWork;
using ARTExhibition.Application.Features.FavoriteArtWork.Commands.DeleteFavoriteArtWorkCommand;
using ARTExhibition.Application.Features.FavoriteArtWork.Queries.GetAllFavoriteQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ARTExhibitionSystem.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteArtWorkController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FavoriteArtWorkController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all favorite artworks for a user
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetFavoriteArtWorks(int userId)
        {
            var query = new GetFavoriteArtWorksQuery(userId);
            var favoriteArtWorks = await _mediator.Send(query);
            return Ok(favoriteArtWorks);
        }

        // Add a favorite artwork
        [HttpPost]
        public async Task<IActionResult> AddFavoriteArtWork([FromBody] FavoriteArtWorkDTO favoriteArtWorkDTO)
        {
            if (favoriteArtWorkDTO == null) return BadRequest("Invalid data");

            var command = new AddFavoriteArtWorkCommand(favoriteArtWorkDTO.UserID, favoriteArtWorkDTO.ArtworkID);
            var result = await _mediator.Send(command);

            if (!result) return BadRequest("Could not add favorite artwork");

            return CreatedAtAction(nameof(GetFavoriteArtWorks), new { userId = favoriteArtWorkDTO.UserID }, favoriteArtWorkDTO);
        }

        // Delete a favorite artwork
        [HttpDelete]
        public async Task<IActionResult> DeleteFavoriteArtWork([FromBody] FavoriteArtWorkDTO favoriteArtWorkDTO)
        {
            if (favoriteArtWorkDTO == null) return BadRequest("Invalid data");

            var command = new DeleteFavoriteArtWorkCommand(favoriteArtWorkDTO.UserID, favoriteArtWorkDTO.ArtworkID);
            var result = await _mediator.Send(command);

            if (!result) return NotFound("Favorite artwork not found");

            return NoContent();
        }
    }
}
