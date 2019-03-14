using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDeck.Models
{
    public class Music
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Album { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 5)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public int Note { get; set; }
    }
}
