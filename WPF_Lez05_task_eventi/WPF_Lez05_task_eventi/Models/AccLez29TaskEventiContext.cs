using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WPF_Lez05_task_eventi.Models;

public partial class AccLez29TaskEventiContext : DbContext
{
    public AccLez29TaskEventiContext()
    {
    }

    public AccLez29TaskEventiContext(DbContextOptions<AccLez29TaskEventiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Partecipante> Partecipantes { get; set; }

    public virtual DbSet<Risorsa> Risorsas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez29_task_eventi;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventoId).HasName("PK__Evento__DE07237CE9CE84B6");

            entity.ToTable("Evento");

            entity.Property(e => e.EventoId).HasColumnName("eventoId");
            entity.Property(e => e.CapMax).HasColumnName("capMax");
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
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasMany(d => d.PartecipanteRifs).WithMany(p => p.EventoRifs)
                .UsingEntity<Dictionary<string, object>>(
                    "EventoPartecipante",
                    r => r.HasOne<Partecipante>().WithMany()
                        .HasForeignKey("PartecipanteRif")
                        .HasConstraintName("FK__Evento_Pa__parte__3E52440B"),
                    l => l.HasOne<Evento>().WithMany()
                        .HasForeignKey("EventoRif")
                        .HasConstraintName("FK__Evento_Pa__parte__3D5E1FD2"),
                    j =>
                    {
                        j.HasKey("EventoRif", "PartecipanteRif").HasName("PK__Evento_P__A0A928B944ACAD15");
                        j.ToTable("Evento_Partecipante");
                        j.IndexerProperty<int>("EventoRif").HasColumnName("eventoRif");
                        j.IndexerProperty<int>("PartecipanteRif").HasColumnName("partecipanteRif");
                    });
        });

        modelBuilder.Entity<Partecipante>(entity =>
        {
            entity.HasKey(e => e.PartecipanteId).HasName("PK__Partecip__59BAFC6ED7D53B0E");

            entity.ToTable("Partecipante");

            entity.HasIndex(e => e.Telefono, "UQ__Partecip__2A16D94591B49516").IsUnique();

            entity.Property(e => e.PartecipanteId).HasColumnName("partecipanteId");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Risorsa>(entity =>
        {
            entity.HasKey(e => e.RisorsaId).HasName("PK__Risorsa__31473CB9210287E0");

            entity.ToTable("Risorsa");

            entity.Property(e => e.RisorsaId).HasColumnName("risorsaId");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.EventoRif).HasColumnName("eventoRif");
            entity.Property(e => e.Fornitore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fornitore");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.Tipo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.EventoRifNavigation).WithMany(p => p.Risorsas)
                .HasForeignKey(d => d.EventoRif)
                .HasConstraintName("FK__Risorsa__eventoR__4316F928");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
