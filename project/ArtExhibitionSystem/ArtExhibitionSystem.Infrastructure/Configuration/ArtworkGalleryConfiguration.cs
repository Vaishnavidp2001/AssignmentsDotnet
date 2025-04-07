using ArtExhibitionSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Configuration
{
    public class ArtworkGalleryConfiguration : IEntityTypeConfiguration<ArtworkGallery>
    {
        public void Configure(EntityTypeBuilder<ArtworkGallery> builder)
        {
            builder.HasData(
                new ArtworkGallery
                {
                    ArtworkId = 1,

                   GalleryId = 1,
                }
                );
        }
    }
}
