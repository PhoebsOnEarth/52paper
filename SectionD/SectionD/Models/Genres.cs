using System;
namespace SectionD.Models
{
    public class Genres
    {
        public Genres()
        {
            Id = new Guid();
            Songs = new List<Songs>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Songs> Songs { get; set; }

    }
}

