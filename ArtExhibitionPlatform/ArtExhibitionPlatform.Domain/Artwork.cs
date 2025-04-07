using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class Artwork
    {
        public int ArtworkID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string ImageURL { get; set; }

        // Foreign Key
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }

        // Navigation Properties
        public ICollection<ArtworkGallery> ArtworkGalleries { get; set; } = new List<ArtworkGallery>();
        public ICollection<FavoriteArtWork> FavoritedByUsers { get; set; } = new List<FavoriteArtWork>();
    }
}

