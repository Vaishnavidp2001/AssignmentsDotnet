using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Domain;

namespace ArtExhibitionSystem.domain
{
    public class Galleries
    { 
        [Key]
        [Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GalleryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        // Foreign Keys
        [Required]
        public int ArtistId { get; set; }

        // Navigation Properties
        public Artists? Artists { get; set; }
        public ICollection<ArtworkGallery>? ArtworkGalleries { get; set; }
    }
}
