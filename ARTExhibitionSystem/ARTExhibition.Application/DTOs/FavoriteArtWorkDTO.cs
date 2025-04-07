using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibition.Application.DTOs
{
    public class FavoriteArtWorkDTO
    {
        public int UserID { get; set; }
        public int ArtworkID { get; set; }
    }


        public class FavoriteArtWorkResponseDTO
        {
            public int UserID { get; set; }
            public int ArtworkID { get; set; }
            public string ArtworkTitle { get; set; } = string.Empty; // You can add more properties as needed
        }
    
}
