﻿using Listify.Domain.Lib.VMs;
using Listify.Lib.DTOs;
using System.Collections.Generic;

namespace Listify.Lib.VMs
{
    public class SongVM : BaseVM
    {
        public string SongName { get; set; } // +2 referneces
        public string YoutubeId { get; set; } // +2 referneces
        public int SongLengthSeconds { get; set; } // +2 referneces

        // Default Thumbnail
        public string ThumbnailUrl { get; set; }
        public int ThumbnailWidth { get; set; }
        public int ThumbnailHeight { get; set; }

        public ICollection<SongRequestDTO> SongRequests { get; set; } =
            new List<SongRequestDTO>();
    }
}
