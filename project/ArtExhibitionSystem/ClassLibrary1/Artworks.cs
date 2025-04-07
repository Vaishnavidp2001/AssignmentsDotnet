using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArtExhibitionSystem.Domain;
namespace ArtExhibitionSystem.domain
{
    public class Artworks
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ArtworkId { get; set; }
        [Required]
        public string Title { get; set; }       
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public int ArtistId { get; set; }
        public Artists? Artists { get; set; }

        public ICollection<FavoriteArtWork>? FavoriteArtWork { get; set; }  
        public ICollection<ArtworkGallery>? ArtworkGallery { get; set; }
    }
}
