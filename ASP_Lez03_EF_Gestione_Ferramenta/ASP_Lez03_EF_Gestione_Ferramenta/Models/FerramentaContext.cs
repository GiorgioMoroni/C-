using Microsoft.EntityFrameworkCore;

namespace ASP_Lez03_EF_Gestione_Ferramenta.Models
{
    public class FerramentaContext : DbContext
    {
        public FerramentaContext(DbContextOptions<FerramentaContext> options) : base(options) { }   //Standard

        public DbSet<Prodotto> Prodotti { get; set; }
    }
}
