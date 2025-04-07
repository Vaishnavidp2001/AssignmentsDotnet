using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ARTExhibitionSystem.Infrastructure.Configuration
{
    public class ArtworkGalleryConfiguration : IEntityTypeConfiguration<ArtworkGallery>
    {
        public void Configure(EntityTypeBuilder<ArtworkGallery> builder)
        {
            // Seed sample artwork-gallery relationships
            builder.HasData(
                new ArtworkGallery { ArtworkID = 1, GalleryID = 2 },
                new ArtworkGallery { ArtworkID = 2, GalleryID = 1 }
            );
        }
    }
}
