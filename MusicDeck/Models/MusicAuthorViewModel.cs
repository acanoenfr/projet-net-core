using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDeck.Models
{
    public class MusicAuthorViewModel
    {
        public List<Music> Musics;
        public SelectList Authors;
        public string MusicAuthor { get; set; }
        public string SearchString { get; set; }
    }
}
