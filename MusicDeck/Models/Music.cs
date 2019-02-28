using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDeck.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Note { get; set; }
    }
}
