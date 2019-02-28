using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDeck.Models
{
    public class Music
    {
        public int id { get; set; }
        public string name { get; set; }
        public string album { get; set; }
        public string author { get; set; }
        public double note { get; set; }
    }
}
