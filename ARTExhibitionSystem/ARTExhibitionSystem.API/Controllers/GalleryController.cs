using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Features.GalleryFeature.Commands.AddGallery;
using ARTExhibition.Application.Features.GalleryFeature.Commands.DeleteGalleryCommand;
using ARTExhibition.Application.Features.GalleryFeature.Commands.UpdateGalleryCommand;
using ARTExhibition.Application.Features.GalleryFeature.Queries.GetAllGalleryQuery;
using ARTExhibitionSystem.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ARTExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GalleryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all galleries
        [HttpGet]
        public async Task<IActionResult> GetAllGalleries()
        {
            var galleries = await _mediator.Send(new GetGalleryQuery());
            return Ok(galleries);
        }

        // Get gallery by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGalleryById(int id)
        {
            var gallery = await _mediator.Send(new GetGalleryByIdQuery(id));
            if (gallery == null) return NotFound();
            return Ok(gallery);
        }

        // Add new gallery
        [HttpPost]
        public async Task<IActionResult> AddGallery([FromBody] CreateGalleryDTO galleryDTO)
        {
            if (galleryDTO == null) return BadRequest("Invalid data");

            var command = new AddGalleryCommand(galleryDTO);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetGalleryById), new { id = result }, result);
        }

        // Update gallery
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGallery(int id, [FromBody] UpdateGalleryDTO galleryDTO) // Use DTO here
        {
            if (id != galleryDTO.GalleryID) return BadRequest("ID mismatch");

            var command = new UpdateGalleryCommand(galleryDTO); // Pass DTO to command
            var success = await _mediator.Send(command);

            if (!success) return NotFound(); // Handle case where update fails

            return NoContent();
        }

        // Delete gallery
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGallery(int id)
        {
            var command = new DeleteGalleryCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
