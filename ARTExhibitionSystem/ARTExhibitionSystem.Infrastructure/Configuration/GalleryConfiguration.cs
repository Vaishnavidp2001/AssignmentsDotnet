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
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            // Seed sample galleries
            builder.HasData(
                new Gallery
                {
                    GalleryID = 1,
                    Name = "Modern Art Gallery",
                    Description = "A gallery featuring modern art.",
                    Location = "New York",
                    ArtistId = 2  // Example: Vincent van Gogh associated gallery
                },
                new Gallery
                {
                    GalleryID = 2,
                    Name = "Classical Art Gallery",
                    Description = "A gallery featuring classical art.",
                    Location = "Paris",
                    ArtistId = 1  // Example: Leonardo da Vinci associated gallery
                }
            );
        }
    }
}
