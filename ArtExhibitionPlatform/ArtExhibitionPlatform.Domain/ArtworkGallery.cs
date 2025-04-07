﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtexibitionPlatform.Domain
{
    public class ArtworkGallery
    {
        public int ArtworkID { get; set; }
        public Artwork Artwork { get; set; }

        public int GalleryID { get; set; }
        public Gallery Gallery { get; set; }
    }
}
