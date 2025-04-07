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
    public class ArtworkConfiguration : IEntityTypeConfiguration<Artwork>
    {
        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            // Seed sample artworks; note that ArtistID must match seeded artists
            builder.HasData(
                new Artwork
                {
                    ArtworkID = 1,
                    Title = "Mona Lisa",
                    Description = "A portrait by Leonardo da Vinci",
                    CreationDate = new DateTime(1503, 1, 1),
                    ImageURL = "https://example.com/monalisa.jpg",
                    ArtistID = 1
                },
                new Artwork
                {
                    ArtworkID = 2,
                    Title = "Starry Night",
                    Description = "A famous painting by Vincent van Gogh",
                    CreationDate = new DateTime(1889, 6, 1),
                    ImageURL = "https://example.com/starrynight.jpg",
                    ArtistID = 2
                }
            );
        }
    }
}
