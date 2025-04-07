using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibition.Application.DTOs
{
    public class ArtworkDTO
    {
        public int ArtworkID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public int ArtistID { get; set; }   // Foreign key reference
    }
}
