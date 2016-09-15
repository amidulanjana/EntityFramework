using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required]
        [StringLength(100,MinimumLength=5)]
        public string name { get; set; }

        public virtual List<Album> Albums { get; set; }

        public virtual ArtistDetails ArtistDetails { get; set; }

    }
}