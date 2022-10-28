using System;
using System.ComponentModel.DataAnnotations;
namespace SectionD.Models
{
    public class Songs
    {

        public Guid Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }
        public virtual Genres Genres { get; set; }
        public string Length
        {
            get
            {
                return Mins + ":" + Secs;
            }
        }
        public Songs()
        {
            Id = new Guid();
        }

    }
}

