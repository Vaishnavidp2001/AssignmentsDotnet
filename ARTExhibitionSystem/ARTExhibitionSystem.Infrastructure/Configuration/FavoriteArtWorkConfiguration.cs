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
    public class FavoriteArtWorkConfiguration : IEntityTypeConfiguration<FavoriteArtWork>
    {
        public void Configure(EntityTypeBuilder<FavoriteArtWork> builder)
        {
            // Seed sample favorite artworks
            builder.HasData(
                new FavoriteArtWork { UserID = 1, ArtworkID = 1 },
                new FavoriteArtWork { UserID = 2, ArtworkID = 2 }
            );
        }
    }
}
