using ArtExhibitionSystem.Application.Features.ArtistFeature.Command.AddGalleries;
using ArtExhibitionSystem.Application.Features.ArtistFeature.Query.GetAllGalleries;
using ArtExhibitionSystem.Application.Features.GalleryFeature.Command.DeleteGallery;
using ArtExhibitionSystem.Application.Features.GalleryFeature.Command.UpdateGallery;
using ArtExhibitionSystem.Application.Features.GalleryFeature.Query;
using ArtExhibitionSystem.domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArtExhibitionSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {
        readonly IMediator _mediator;
        public GalleriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GetAllGalleries

        [HttpGet]
        public async Task<IActionResult> GetAllGalleries()
        {
             var allgaleries= await _mediator.Send(new GetAllGalleriesQuery());
            return  Ok(allgaleries);
        }

        //AddGalleries

        [HttpPost]
        public async Task<IActionResult> AddGalleries(Galleries galleries)
        {
            var result = await _mediator.Send(new AddGalleriesCommand(galleries));
            return Ok(result);
        }

        //GetGalleryByIDQuery

        [HttpGet ("{galleryID}")]
        public async Task<IActionResult>GetGalleryByIDQuery(int galleryID)
        {
            var result=await _mediator.Send(new GetGalleryByIDQuery(galleryID));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult>UpdateGallery(Galleries galleries)
        {
            var result = await _mediator.Send(new UpdateGalleryCommand(galleries));
            return Ok(result);
        }

        //delete

        [HttpDelete]
        public async Task<IActionResult>RemoveGalleries(int galleryID)
        {
            var result = await _mediator.Send(new DeleteGalleryCommand(galleryID));
            return Ok(result);
        }



    }
}
