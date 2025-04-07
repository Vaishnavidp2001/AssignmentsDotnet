using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibitionSystem.Domain.Entities
{
    public class ArtworkGallery
    {

        //ArtworkGallery.cs (Join Table for Artwork - Gallery)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ArtworkID { get; set; }
        public Artwork Artwork { get; set; }

        public int GalleryID { get; set; }

        [ForeignKey("GalleryID")]
        public Gallery Gallery { get; set; }
    }
}
