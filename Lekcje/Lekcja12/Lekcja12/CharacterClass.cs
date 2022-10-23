using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja12
{
    public class CharacterType
    {
        [Key]
        public int Key { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        public List<Character>? Characters { get; set; }
    }
}
