﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public DbSet<ArtistDetails> ArtistDetails { get; set; }
    }
}