using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibitionSystem.Domain.Entities
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; } = string.Empty;

        public ICollection<Artwork>? Artworks { get; set; } = new List<Artwork>();
        public string Bio { get; set; }
    }
}
