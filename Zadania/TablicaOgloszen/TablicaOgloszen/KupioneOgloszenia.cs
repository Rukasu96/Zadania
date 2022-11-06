using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    public class KupioneOgloszenia
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public User? User { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
    }
}
