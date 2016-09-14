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
            context.Artists.Add(new Artist() { name = "New Data1" });
            context.Artists.Add(new Artist() { name = "New Data2" });
            context.SaveChanges();  
        }
    }
}