using ArtExhibitionSystem.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Configuration
{
    public class GalleriesConfiguration : IEntityTypeConfiguration<Galleries>
    {
        public void Configure(EntityTypeBuilder<Galleries> builder)
        {
            builder.HasData(
              new Galleries
              {
                  GalleryId = 1,
                  Name = "Modern Art Gallery",
                  Description = "A collection of modern artworks",
                  Location = "New York",
                  ArtistId = 1
              });
        }
    }
} 