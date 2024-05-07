using System.ComponentModel.DataAnnotations;

namespace ASP_Lez09_contatti_CODEFIRST.Models
{
    public class Contatto
    {
        [Key]
        public int ContattoId { get; set; }

        [MaxLength(250)]
        [Required] //NOT NULL
        public string Nome { get; set; } = null!;

        [MaxLength(250)]
        public string? Cognome { get; set; }

        [MaxLength(250)]
        [Required] //NOT NULL
        public string Telefono { get; set; } = null!;

        [MaxLength(250)]
        public string? Email { get; set; }
    }
}
