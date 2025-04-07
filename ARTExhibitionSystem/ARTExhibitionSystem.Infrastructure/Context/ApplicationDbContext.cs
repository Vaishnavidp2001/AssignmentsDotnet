using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ARTExhibitionSystem.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<FavoriteArtWork> FavoriteArtWorks { get; set; }
        public DbSet<ArtworkGallery> ArtworkGalleries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply the Artist configuration
            //modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            //modelBuilder.ApplyConfiguration(new ArtworkConfiguration());
            //modelBuilder.ApplyConfiguration(new GalleryConfiguration());
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new FavoriteArtWorkConfiguration());
            //modelBuilder.ApplyConfiguration(new ArtworkGalleryConfiguration());


            // Many-to-Many Relationships
            modelBuilder.Entity<FavoriteArtWork>()
                .HasKey(fa => new { fa.UserID, fa.ArtworkID });

            modelBuilder.Entity<ArtworkGallery>()
                .HasKey(ag => new { ag.ArtworkID, ag.GalleryID });
        }

        public DbSet<User> User { get; set; }
    }
}
