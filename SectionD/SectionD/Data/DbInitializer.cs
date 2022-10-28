using System;
using SectionD.Models;
namespace SectionD.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbSongs context)
        {
            if (context.Songs.Any())
            {
                return;
            }
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var genres = new Genres[]
            {
                new Genres{Name="Classical"},
                new Genres{Name="Pop"}
            };
            foreach (Genres g in genres)
            {
                context.Genres.Add(g);
            }

            context.SaveChanges();
       
            var songs = new Songs[]
            {
                new Songs{Title="Fly Me To The Moon",Mins=5,Secs=42,Genres=genres[0]},
                new Songs{Title="Canon In D",Mins=5,Secs=11,Genres=genres[1]},
                new Songs{Title="Let It Be",Mins=5,Secs=58,Genres=genres[0]},
                new Songs{Title="Somewhere Out There",Mins=4,Secs=48,Genres=genres[1]},
                new Songs{Title="Hallelujah",Mins=4,Secs=15,Genres=genres[0]}
            };
            foreach(Songs s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();
        
            
        }
    }
}

