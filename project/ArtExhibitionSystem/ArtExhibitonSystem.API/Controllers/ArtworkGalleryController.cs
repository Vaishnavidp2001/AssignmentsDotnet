using ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.Addfeature;
using ArtExhibitionSystem.Application.Features.ArtworkGalleryFeature.Command.DeleteFeature;
using ArtExhibitionSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtworkGalleryController : ControllerBase
    {
        readonly IMediator _mediatoR;
        public ArtworkGalleryController(IMediator mediator)
        {
            _mediatoR=mediator;
        }

        //AddArtworkGallery
        [HttpPost]
        public async Task<IActionResult> AddArtworkGallery(ArtworkGallery artworkGallery)
        {
            var result = await _mediatoR.Send(new AddArtworkGalleryCommand(artworkGallery));
            return Ok(result);
        }

        //DeleteArtworkGallery

        [HttpDelete]
        public async Task<IActionResult>DeleteArtworkGallery(int artworkId,int galleryid)
        {
            var result = await _mediatoR.Send(new DeleteArtworkGalleryCommand(artworkId,galleryid));
            return Ok(result);
        }
    }
}
