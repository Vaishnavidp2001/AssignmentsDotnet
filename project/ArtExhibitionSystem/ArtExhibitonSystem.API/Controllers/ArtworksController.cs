using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddArtwork;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.RemoveArtwork;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.UpdateArtwork;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllArtworkQuery;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetArtworkByIdQuery;
using ArtExhibitionSystem.domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 //   [Authorize]
    public class ArtworksController : ControllerBase
    {
        readonly IMediator _mediatoR;

        public ArtworksController(IMediator mediatoR)
        {
            _mediatoR=mediatoR;
        }

        //GetAllArtwork
        [HttpGet]
        public async  Task<IActionResult> GetAllArtwork() 
        {
            var allartworks= await _mediatoR.Send(new GetAllArtworkQuery());
            return Ok(allartworks);
        }

        //AddArtworkAsync
        [HttpPost]
        public async Task<IActionResult> AddArtworkAsync(Artworks artworks)
        {
           var result=await _mediatoR.Send(new AddArtworkCommand(artworks));
            return Ok(result);
        }

       

        //GetArtworkByIdAsync

        [HttpGet("{artworkId}")]
        public async Task<IActionResult> GetArtworkByIdAsync(int artworkId)
        {
            var result=await _mediatoR.Send(new GetArtworkByIdQuery(artworkId));
            return Ok(result);
        }

        //update
        [HttpPut]
        public async Task<IActionResult> UpdateArtworkAsync(Artworks artworks)
        {
            var result = await _mediatoR.Send(new UpdateArtworkCommand(artworks));
            return Ok(result);
        }

        //delete
        [HttpDelete]
        public async Task<IActionResult> RemoveArtworkAsync(int artworkId)
        {
            var result=await _mediatoR.Send(new RemoveArtworkCommand(artworkId));
            return Ok(result);
        }

    }
}
