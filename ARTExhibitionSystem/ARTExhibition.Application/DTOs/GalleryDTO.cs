using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibition.Application.DTOs
{
    public class GalleryDTO
    {
        public int GalleryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int ArtistID { get; set; }  // Foreign key reference
    }


    public class CreateGalleryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int ArtistID { get; set; }
    }


    public class UpdateGalleryDTO
    {
        public int GalleryID { get; set; } // Required for update
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
