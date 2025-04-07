using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibitionSystem.Domain.Entities
{
    public class Artwork
    {
        public int ArtworkID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public string ImageURL { get; set; } = string.Empty;

        // Relationships
        public int ArtistID { get; set; }

        [ForeignKey("ArtistID")]
        public Artist? Artist { get; set; } = null!;

        //public ICollection<FavoriteArtWork> FavoritedByUsers { get; set; } = new List<FavoriteArtWork>();
        //public ICollection<ArtworkGallery> ArtworkGalleries { get; set; } = new List<ArtworkGallery>();
        public decimal Price { get; set; }
    }
}
