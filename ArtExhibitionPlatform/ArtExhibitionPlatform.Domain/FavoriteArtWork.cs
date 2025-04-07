﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class FavoriteArtWork
    {
        public int UserID { get; set; }
        public User User { get; set; }

        public int ArtworkID { get; set; }
        public Artwork Artwork { get; set; }
    }
}
