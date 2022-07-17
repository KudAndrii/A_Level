using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskFour.Models
{
    [Table(nameof(Artist))]
    public class Artist
    {
        public Artist()
        {
            Songs = new List<ArtistSong>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? InstagramUrl { get; set; }

        public virtual List<ArtistSong> Songs { get; set; }
    }
}
