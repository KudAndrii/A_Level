using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskFour.Models
{
    [Table(nameof(Song))]
    public class Song
    {
        public Song()
        {
            Performers = new List<ArtistSong>();
        }

        public int SongId { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// Should have next format "mm:ss".
        /// <value>Max length is 5.</value>
        /// </summary>
        public string Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual List<ArtistSong> Performers { get; set; }
    }
}
