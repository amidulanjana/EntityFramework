using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var artist = context.Artists.Count();
                Console.WriteLine(artist);
                Console.ReadLine();

            }
            
        }

        public class Artist
        {
            public int ID { get; set; }
            public string name { get; set; }
        }

        public class MusicContext : DbContext
        {
            public DbSet<Artist> Artists { get; set; }
        }

    }
}
