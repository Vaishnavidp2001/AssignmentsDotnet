

using ArtExhibitionSystem.domain;
using MediatR;

namespace ArtExhibitionSystem.Application.Features.GalleryFeature.Query
{
    public record GetGalleryByIDQuery(int galleryId):IRequest<Galleries>;
}
