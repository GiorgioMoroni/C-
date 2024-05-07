using Microsoft.EntityFrameworkCore;

namespace ASP_Lez09_contatti_CODEFIRST.Models
{
    public class ContattoContext : DbContext
    {
        public ContattoContext(DbContextOptions<ContattoContext> options) : base(options) { }

        DbSet<Contatto> Contattos { get; set; }

    }
}
