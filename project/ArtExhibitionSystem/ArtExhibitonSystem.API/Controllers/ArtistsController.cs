using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtist;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.DeleteArtist;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtist;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtists;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtistById;
using ArtExhibitionSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ArtistsController : ControllerBase
    {
        readonly IMediator _mediatoR;
        public ArtistsController(IMediator mediatoR)
        {
            _mediatoR = mediatoR;
        }

        //GetAllArtists
       
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllArtists()
        {
            var allartists = await _mediatoR.Send(new GetAllArtistsQuery());
            return Ok(allartists);
        }


        //AddArtists

        [HttpPost]
        public async Task<IActionResult> AddArtists(Artists artist)
        {
            var result = await _mediatoR.Send(new AddArtistCommand(artist));
            return Ok(result);
        }

        //GetArtistById

        [HttpGet("{artistId}")]
        public async Task<IActionResult> GetArtistById(int artistId)
        {
            var result = await _mediatoR.Send(new GetArtistByIdQuery(artistId));
            return Ok(result);
        }

        //UpdateArtist
        [HttpPut]
        public async Task<IActionResult> UpdateArtist(Artists artists)
        {
            var result = await _mediatoR.Send(new UpdateArtistCommand(artists));
            return Ok(result);
        }

        //deleteArtist
        [HttpDelete]

        public async Task<IActionResult> DeleteArtist(int artistId)
        {
            var result = await _mediatoR.Send(new DeleteArtistCommand(artistId));
            return Ok(result);
        }
      





    }
}
