//using System.Collections.Generic;
//using System.Reflection.Emit;
//using ArtexibitionPlatform.Domain;
//using Microsoft.EntityFrameworkCore;

//namespace ArtexibitionPlatform.Infrastructure.Context
//{
//    public class ArtExhibitionDbContext : DbContext
//    {
//        public ArtExhibitionDbContext(DbContextOptions<ArtExhibitionDbContext> options) : base(options) { }

//        public DbSet<User> Users { get; set; }
//        public DbSet<Artist> Artists { get; set; }
//        public DbSet<Artwork> Artworks { get; set; }
//        public DbSet<Gallery> Galleries { get; set; }
//        public DbSet<FavoriteArtWork> FavoriteArtWorks { get; set; }
//        public DbSet<ArtworkGallery> ArtworkGalleries { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configure Many-to-Many Relationships
//            modelBuilder.Entity<FavoriteArtWork>()
//                .HasKey(f => new { f.UserID, f.ArtworkID });

//            modelBuilder.Entity<ArtworkGallery>()
//                .HasKey(ag => new { ag.ArtworkID, ag.GalleryID });
//        }
//    }
//}



using Microsoft.EntityFrameworkCore;
using ArtexibitionPlatform.Domain;

namespace ArtExhibitionPlatform.Infrastructure.Context
{
    public class ArtExhibitionDbContext : DbContext
    {
        public ArtExhibitionDbContext(DbContextOptions<ArtExhibitionDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<FavoriteArtWork> FavoriteArtWorks { get; set; }
        public DbSet<ArtworkGallery> ArtworkGalleries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Many-to-Many Relationships
            modelBuilder.Entity<FavoriteArtWork>()
                .HasKey(f => new { f.UserID, f.ArtworkID });

            modelBuilder.Entity<ArtworkGallery>()
                .HasKey(ag => new { ag.ArtworkID, ag.GalleryID });

            // Disable cascading delete for ArtworkGallery to avoid multiple cascade paths issue
            modelBuilder.Entity<ArtworkGallery>()
                .HasOne(ag => ag.Artwork)
                .WithMany(a => a.ArtworkGalleries)
                .HasForeignKey(ag => ag.ArtworkID)
                .OnDelete(DeleteBehavior.NoAction); // 👈 Prevents multiple cascade paths

            modelBuilder.Entity<ArtworkGallery>()
                .HasOne(ag => ag.Gallery)
                .WithMany(g => g.ArtworkGalleries)
                .HasForeignKey(ag => ag.GalleryID)
                .OnDelete(DeleteBehavior.NoAction); // 👈 Prevents multiple cascade paths
        }
    }
}
