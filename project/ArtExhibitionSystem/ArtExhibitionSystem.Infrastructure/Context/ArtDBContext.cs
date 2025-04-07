using ArtExhibitionSystem.domain;
using ArtExhibitionSystem.Domain;
using ArtExhibitionSystem.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionSystem.Infrastructure.Context
{
    public class ArtDBContext:DbContext
    {
        public ArtDBContext(DbContextOptions<ArtDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistsConfiguration());
            modelBuilder.ApplyConfiguration(new ArtworkConfiguration());
            modelBuilder.ApplyConfiguration(new GalleriesConfiguration());
            modelBuilder.ApplyConfiguration(new ArtworkGalleryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Artworks> Artworks { get; set; }
        public DbSet<FavoriteArtWork> FavoriteArtWork { get; set; }
        public DbSet<Galleries> Galleries  { get; set; }
        public DbSet<ArtworkGallery> ArtworkGallery { get; set; }






    }
}
