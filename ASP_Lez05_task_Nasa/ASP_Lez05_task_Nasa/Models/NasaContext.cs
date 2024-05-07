using Microsoft.EntityFrameworkCore;

namespace ASP_Lez05_task_Nasa.Models
{
    public class NasaContext : DbContext
    {
        public NasaContext(DbContextOptions<NasaContext> options) : base(options) { }


        public DbSet<Sistema> Sistemi { get; set; }

        public DbSet<OggettoCeleste> OggettiCelesti { get; set; }
        public DbSet<SistemaOggetto> SistemaOggettos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SistemaOggetto>().HasKey(i => new {i.SistemaRIF, i.OggettoRIF});

            modelBuilder.Entity<SistemaOggetto>()
                .HasOne(so => so.Ogg)
                .WithMany(o => o.ElencoSisOgg)
                .HasForeignKey(so => so.OggettoRIF);

            modelBuilder.Entity<SistemaOggetto>()
                .HasOne(so => so.Sis)
                .WithMany(s => s.ElencoSisOgg)
                .HasForeignKey(so => so.SistemaRIF);

        }

    }
}
