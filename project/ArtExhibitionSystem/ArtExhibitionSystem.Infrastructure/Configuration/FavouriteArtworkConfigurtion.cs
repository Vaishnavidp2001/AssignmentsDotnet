using ArtExhibitionSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Infrastructure.Configuration
{
    public class FavouriteArtworkConfigurtion : IEntityTypeConfiguration<FavoriteArtWork>
    {
        public void Configure(EntityTypeBuilder<FavoriteArtWork> builder)
        {
            builder.HasData(
                new FavoriteArtWork
                {
                    FavouriteArtWorkId=0,
                    UserId=0,
                    ArtworkId=0,
                    //Artworks =
                });
        }
    }
}
