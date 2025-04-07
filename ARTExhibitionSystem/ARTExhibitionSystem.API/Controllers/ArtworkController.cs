using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using ARTExhibition.Application.Features.ArtworkFeature.Commands;
using ARTExhibition.Application.Features.ArtworkFeature.Queries;


namespace ARTExhibitionSystem.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArtworkController : ControllerBase
    {
        private readonly IArtworkRepository _artworkRepository;

        public ArtworkController(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArtworks()
        {
            var artworks = await _artworkRepository.GetAllArtworksAsync();
            return Ok(artworks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtworkById(int id)
        {
            var artwork = await _artworkRepository.GetArtworkByIdAsync(id);
            if (artwork == null) return NotFound();
            return Ok(artwork);
        }

        [HttpPost]
        public async Task<IActionResult> AddArtwork([FromBody] Artwork artwork)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _artworkRepository.AddArtworkAsync(artwork);
            return CreatedAtAction(nameof(GetArtworkById), new { id = artwork.ArtworkID }, artwork);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtwork(int id, [FromBody] Artwork artwork)
        {
            if (id != artwork.ArtworkID) return BadRequest("ID mismatch");
            await _artworkRepository.UpdateArtworkAsync(artwork);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtwork(int id)
        {
            await _artworkRepository.DeleteArtworkAsync(id);
            return NoContent();
        }
    }
}
