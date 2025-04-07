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
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            // Seed data for the Artist entity
            builder.HasData(
                new Artist
                {
                    ArtistID = 1,
                    Name = "Leonardo da Vinci",
                    BirthDate = new DateTime(1452, 4, 15),
                    Phone = "1234567890"
                },
                new Artist
                {
                    ArtistID = 2,
                    Name = "Vincent van Gogh",
                    BirthDate = new DateTime(1853, 3, 30),
                    Phone = "0987654321"
                }
            );
        }
    }
}
