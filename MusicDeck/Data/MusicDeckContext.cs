using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicDeck.Models
{
    public class MusicDeckContext : DbContext
    {
        public MusicDeckContext (DbContextOptions<MusicDeckContext> options)
            : base(options)
        {
        }

        public DbSet<MusicDeck.Models.Music> Music { get; set; }
    }
}
