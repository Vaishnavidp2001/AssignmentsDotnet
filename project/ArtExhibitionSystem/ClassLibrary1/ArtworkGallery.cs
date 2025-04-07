using System.ComponentModel.DataAnnotations;
using ArtExhibitionSystem.domain;

namespace ArtExhibitionSystem.Domain
{
    public class ArtworkGallery
    {
        [Key]
        [Required]
        public int ArtworkId { get; set; }
        public Artworks? Artworks { get; set; }

        [Required]
        public int GalleryId { get; set; }
        public Galleries? Galleries { get; set; }
    }
}
