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
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public DateTime ReleasedDate { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual List<Artist> Performers { get; set; } = new List<Artist>();
    }
}
