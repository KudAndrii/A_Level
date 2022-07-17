using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskFour.Models
{
    [Table(nameof(ArtistSong))]
    public class ArtistSong
    {
        public int ArtistId { get; set; }
        public int SongId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
    }
}
