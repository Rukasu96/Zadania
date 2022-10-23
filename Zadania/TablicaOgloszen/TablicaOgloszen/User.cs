using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Email { get; set; }

        public List<Ogloszenie>? Ogloszenia { get; set; }

        public User()
        {
            Ogloszenia = new List<Ogloszenie>();
        }

    }
}
