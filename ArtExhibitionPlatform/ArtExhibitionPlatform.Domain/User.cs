using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation Properties
        public ICollection<FavoriteArtWork> FavoriteArtWorks { get; set; } = new List<FavoriteArtWork>();
    }
}

