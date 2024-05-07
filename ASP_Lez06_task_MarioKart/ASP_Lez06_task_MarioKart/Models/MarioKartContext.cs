using Microsoft.EntityFrameworkCore;

namespace ASP_Lez06_task_MarioKart.Models
{
    public class MarioKartContext : DbContext
    {
        public MarioKartContext(DbContextOptions<MarioKartContext> options) : base(options)
        {

        }

        public DbSet<Personaggio> Personaggios { get; set; }
        public DbSet<Squadra> Squadres { get; set; }
        public DbSet<Torneo> Torneos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Squadra>()
            .HasKey(s => new { s.IdSquadra });

            modelBuilder.Entity<Personaggio>()
            .HasKey(p => new { p.IdPersonaggio });

            modelBuilder.Entity<Torneo>()
            .HasKey(t => new { t.IdTorneo });



            modelBuilder.Entity<Squadra>()
                .HasOne(s => s.PersonaggioRifUnoNavigation)
                .WithMany()
                .HasForeignKey(s => s.persUnoRIF);

            modelBuilder.Entity<Squadra>()
                .HasOne(s => s.PersonaggioRifDueNavigation)
                .WithMany()
                .HasForeignKey(s => s.persDueRIF);

            modelBuilder.Entity<Squadra>()
                .HasOne(s => s.PersonaggioRifTreNavigation)
                .WithMany()
                .HasForeignKey(s => s.persTreRIF);

            modelBuilder.Entity<Torneo>()
                .HasOne(t => t.SquadraRifUnoNavigation)
                .WithMany()
                .HasForeignKey(t => t.squadraUnoRIF);

            modelBuilder.Entity<Torneo>()
                .HasOne(t => t.SquadraRifDueNavigation)
                .WithMany()
                .HasForeignKey(t => t.squadraDueRIF);

            modelBuilder.Entity<Torneo>()
                .HasOne(t => t.SquadraRifTreNavigation)
                .WithMany()
                .HasForeignKey(t => t.squadraTreRIF);
        }

    }


        


    }
}
