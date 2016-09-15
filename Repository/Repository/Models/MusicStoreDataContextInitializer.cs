using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class MusicStoreDataContextInitializer:DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist = new Artist() { name = "Artist1" };
            context.Artists.Add(artist);
            context.Artists.Add(new Artist() { name = "Artist2" });

            context.Albums.Add(new Album() { Artist = artist, Title = "album1" });
            context.Albums.Add(new Album()
            {
                Artist = context.Artists.Add(new Artist() { name = "Artist3" }),
                Title = "album2"
            });

            context.SaveChanges();  
        }
    }
}