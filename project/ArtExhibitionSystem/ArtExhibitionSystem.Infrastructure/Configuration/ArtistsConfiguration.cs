using ArtExhibitionSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Configuration
{
    public class ArtistsConfiguration : IEntityTypeConfiguration<Artists>
    {
        public void Configure(EntityTypeBuilder<Artists> builder)
        {
            builder.HasData(
                new Artists
                {
                    ArtistID = 1,
                    ArtistName = "VaishnaviPatil",
                    ArtistPhone = "12345678",
                    ArtistBirthdate = new DateTime(2001,5,19)
                    

                },
                 new Artists
                 {
                     ArtistID = 2,
                     ArtistName = "RupaPatil",
                     ArtistPhone = "0987654321",
                     ArtistBirthdate = new DateTime(2001, 02, 05)
                 });
        }
    }
}
