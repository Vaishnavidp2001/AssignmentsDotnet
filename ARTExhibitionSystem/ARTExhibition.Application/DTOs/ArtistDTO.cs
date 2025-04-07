using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibition.Application.DTOs
{
    public class ArtistDTO
    {
        public int ArtistID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; } = string.Empty;
 
        public string Bio { get; set; }
    }

    public class CreateArtistDTO
    {
        public string Name { get; set; }
        public string Bio { get; set; }
    }

    public class UpdateArtistDTO
    {
        public int ArtistID { get; set; }  // Required for update
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
