using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class Gallery
    {
        public int GalleryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        // Foreign Key
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }

        // Navigation Properties
        public ICollection<ArtworkGallery> ArtworkGalleries { get; set; } = new List<ArtworkGallery>();
    }
}

