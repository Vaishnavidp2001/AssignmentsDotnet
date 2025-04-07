//using ARTExhibitionSystem.Domain.Entities;
//using ARTExhibitionSystem.Infrastructure.Repositories;
//using Microsoft.AspNetCore.Mvc;
//using ARTExhibition.Application.Interfaces;
//using ARTExhibition.Application.Features.ArtistFeature.Commands;
//using MediatR;
//using ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery;

//namespace ARTExhibitionSystem.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ArtistController : ControllerBase
//    {
//        //private readonly IArtistRepository _artistRepos;

//        //public ArtistController(IArtistRepository artistRepository)
//        //{
//        //    _artistRepos= artistRepository;
//        //}

//        //[HttpGet]
//        //public async Task<IActionResult> GetAllArtists()
//        //{
//        //    var artists = await _artistRepos.GetAllArtistsAsync();
//        //    return Ok(artists);
//        //}

//        //[HttpGet("{id}")]
//        //public async Task<IActionResult> GetArtistById(int id)
//        //{
//        //    var artist = await _artistRepos.GetArtistByIdAsync(id);
//        //    if (artist == null) return NotFound();
//        //    return Ok(artist);
//        //}

//        //[HttpPost]
//        //public async Task<IActionResult> AddArtist(Artist artist)
//        //{
//        //     var result=await _artistRepos.AddArtist(artist);
//        //    return Ok(result);
//        //}

//        //[HttpPut("{id}")]
//        //public async Task<IActionResult> UpdateArtist(int id, [FromBody] Artist artist)
//        //{
//        //    if (id != artist.ArtistID) return BadRequest("ID mismatch");
//        //    await _artistRepos.UpdateArtistAsync(artist);
//        //    return NoContent();
//        //}

//        //[HttpDelete("{id}")]
//        //public async Task<IActionResult> DeleteArtist(int id)
//        //{
//        //    await _artistRepos.DeleteArtistAsync(id);
//        //    return NoContent();
//        //}

//        private readonly IMediator _mediator;

//        public ArtistController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAllArtists()
//        {
//            var artists = await _mediator.Send(new GetArtistQuery());
//            return Ok(artists);
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetArtistById(int id)
//        {
//            var artist = await _mediator.Send(new GetArtistByIdQuery(id));
//            if (artist == null) return NotFound();
//            return Ok(artist);
//        }

//        [HttpPost]
//        public async Task<IActionResult> AddArtist([FromBody] Artist artist)
//        {

//            var result = await _mediator.Send(new CreateArtistCommand ());
//            return Ok(result);
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateArtist(int id, [FromBody] Artist artist)
//        {

//            var command = new UpdateArtistCommand(new UpdateArtistCommand());
//            await _mediator.Send(command);
//            return NoContent();
//        }

//        //[HttpDelete("{id}")]
//        //public async Task<IActionResult> DeleteArtist(int id)
//        //{
//        //    var command = new DeleteArtistCommand(id);
//        //    await _mediator.Send(command);
//        //    return NoContent();
//        //}
//    }
//}


using ARTExhibitionSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using ARTExhibition.Application.Features.ArtistFeature.Commands;
using ARTExhibition.Application.Features.ArtistFeature.Queries.GetAllArtistQuery;
using ARTExhibition.Application.DTOs;
using ARTExhibition.Application.Features.ArtistFeature.Commands.AddArtist;
//using ARTExhibition.Application.Features.ArtistFeature.Commands.UpdateArtist
using ARTExhibition.Application.Features.ArtistFeature.Commands.DeleteArtistCommand;
using ARTExhibition.Application.Features.ArtistFeature.Commands.UpdateArtistCommand;
using Microsoft.AspNetCore.Authorization;

namespace ARTExhibitionSystem.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
         readonly IMediator _mediator;

        public ArtistController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all artists
        [HttpGet]
        public async Task<IActionResult> GetAllArtists()
        {
            var artists = await _mediator.Send(new GetArtistQuery());
            return Ok(artists);
        }

        // Get artist by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtistById(int id)
        {
            var artist = await _mediator.Send(new GetArtistByIdQuery(id));
            if (artist == null) return NotFound();
            return Ok(artist);
        }

        // Add new artist (Fixed)
        [HttpPost]
        public async Task<IActionResult> AddArtist([FromBody] CreateArtistDTO artistDTO)
        {
            if (artistDTO == null) return BadRequest("Invalid data");

            var command = new AddArtistCommand(artistDTO);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetArtistById), new { id = result }, result);
        }

        //Update artist (Fixed)
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtist(int id, [FromBody] UpdateArtistDTO artistDTO)
        {
            if (id != artistDTO.ArtistID) return BadRequest("ID mismatch");

            var command = new UpdateArtistCommand(artistDTO);
            await _mediator.Send(command);

            return NoContent();
        }

        // Delete artist
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            var command = new DeleteArtistCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
