using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibitionSystem.Domain.Entities
{
    public class FavoriteArtWork
    {

        //FavoriteArtWork.cs (Join Table for User - Artwork)

        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; } 

        public int ArtworkID { get; set; }

        [ForeignKey("ArtworkID")]
        public Artwork Artwork { get; set; }  
    }
}
