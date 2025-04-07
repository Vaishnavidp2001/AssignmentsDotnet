using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        // Navigation Properties
        public ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
        public ICollection<Gallery> Galleries { get; set; } = new List<Gallery>();
    }
}
