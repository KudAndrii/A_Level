using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskFour.Models
{
    [Table(nameof(Genre))]
    public class Genre
    {
        public int GenreId { get; set; }
        public string Title { get; set; }

        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
