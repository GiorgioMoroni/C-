using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Esercitazione04_22_03_2024.Models;

public partial class AccLez28EsercitazioneEventiContext : DbContext
{
    public AccLez28EsercitazioneEventiContext()
    {
    }

    public AccLez28EsercitazioneEventiContext(DbContextOptions<AccLez28EsercitazioneEventiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Partecipante> Partecipantes { get; set; }

    public virtual DbSet<Risorse> Risorses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez28_esercitazione_eventi;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Evento__C8DC7BDA926416BF");

            entity.ToTable("Evento");

            entity.Property(e => e.IdEvento).HasColumnName("idEvento");
            entity.Property(e => e.CapacitaMax).HasColumnName("capacitaMax");
            entity.Property(e => e.DataEvento)
                .HasColumnType("datetime")
                .HasColumnName("dataEvento");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Luogo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("luogo");
            entity.Property(e => e.NomeEvento)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nomeEvento");

            entity.HasMany(d => d.PartecipanteRifs).WithMany(p => p.EventoRifs)
                .UsingEntity<Dictionary<string, object>>(
                    "PartecipanteEvento",
                    r => r.HasOne<Partecipante>().WithMany()
                        .HasForeignKey("PartecipanteRif")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Partecipa__parte__3C69FB99"),
                    l => l.HasOne<Evento>().WithMany()
                        .HasForeignKey("EventoRif")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Partecipa__event__3D5E1FD2"),
                    j =>
                    {
                        j.HasKey("EventoRif", "PartecipanteRif").HasName("PK__Partecip__20AA1CF42264C9F4");
                        j.ToTable("Partecipante_Evento");
                        j.IndexerProperty<int>("EventoRif").HasColumnName("eventoRIF");
                        j.IndexerProperty<int>("PartecipanteRif").HasColumnName("partecipanteRIF");
                    });
        });

        modelBuilder.Entity<Partecipante>(entity =>
        {
            entity.HasKey(e => e.IdPartecipante).HasName("PK__Partecip__CC455B51E59A923A");

            entity.ToTable("Partecipante");

            entity.HasIndex(e => e.Telefono, "UQ__Partecip__2A16D9454966A1BC").IsUnique();

            entity.Property(e => e.IdPartecipante).HasColumnName("idPartecipante");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NomePar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nomePar");
            entity.Property(e => e.Telefono)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Risorse>(entity =>
        {
            entity.HasKey(e => e.IdRisorsa).HasName("PK__Risorse__452CFB5CABCEFACE");

            entity.ToTable("Risorse");

            entity.HasIndex(e => e.Codice, "UQ__Risorse__40F9C18B2FEBD672").IsUnique();

            entity.Property(e => e.IdRisorsa).HasColumnName("idRisorsa");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.Fornitore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fornitore");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
