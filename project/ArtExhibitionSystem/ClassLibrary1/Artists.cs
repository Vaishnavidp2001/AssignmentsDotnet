using System.ComponentModel.DataAnnotations;
using ArtExhibitionSystem.domain;
namespace ArtExhibitionSystem.Domain
{
    public class Artists
    {
        [Key]
        [Required]
        public int ArtistID { get; set; }
        [Required]
        public string ArtistName { get; set; }
        public DateTime ArtistBirthdate { get; set; }
        public string ArtistPhone { get; set; }
        public ICollection<Artworks>? Artworks { get; set; }
        public ICollection<Galleries>? Galleries { get; set; }

    }
}
