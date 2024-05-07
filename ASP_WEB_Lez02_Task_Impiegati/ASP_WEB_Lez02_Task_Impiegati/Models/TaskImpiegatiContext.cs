using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_Lez02_Task_Impiegati.Models;

public partial class TaskImpiegatiContext : DbContext
{
    public TaskImpiegatiContext()
    {
    }

    public TaskImpiegatiContext(DbContextOptions<TaskImpiegatiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cittum> Citta { get; set; }

    public virtual DbSet<Impiegato> Impiegatos { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=Task_Impiegati;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cittum>(entity =>
        {
            entity.HasKey(e => e.CittaId).HasName("PK__Citta__3EF53F5163167A70");

            entity.HasIndex(e => e.CodiceCitta, "UQ__Citta__82D2F009CC19DA19").IsUnique();

            entity.Property(e => e.CittaId).HasColumnName("cittaId");
            entity.Property(e => e.CodiceCitta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codice_citta");
            entity.Property(e => e.NomeCitta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_citta");
            entity.Property(e => e.ProvRif).HasColumnName("provRIF");

            entity.HasOne(d => d.ProvRifNavigation).WithMany(p => p.Citta)
                .HasForeignKey(d => d.ProvRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Citta__provRIF__3B75D760");
        });

        modelBuilder.Entity<Impiegato>(entity =>
        {
            entity.HasKey(e => e.ImpiegatoId).HasName("PK__Impiegat__C7A20D320EFA34E3");

            entity.ToTable("Impiegato");

            entity.HasIndex(e => e.Matricola, "UQ__Impiegat__2C2751BA1EE412FE").IsUnique();

            entity.Property(e => e.ImpiegatoId).HasColumnName("impiegatoId");
            entity.Property(e => e.Citta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("citta");
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.DataNascita).HasColumnName("data_nascita");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Matricola)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.NomeImp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_imp");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("provincia");
            entity.Property(e => e.Reparto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reparto");
            entity.Property(e => e.Ruolo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ruolo");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProvId).HasName("PK__Provinci__DD1B08A0D5A097E3");

            entity.HasIndex(e => e.CodiceProv, "UQ__Provinci__7E1C5B690613C333").IsUnique();

            entity.Property(e => e.ProvId).HasColumnName("provId");
            entity.Property(e => e.CodiceProv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codice_prov");
            entity.Property(e => e.NomeProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_prov");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoId).HasName("PK__Reparto__612C4FD6DA9D3854");

            entity.ToTable("Reparto");

            entity.HasIndex(e => e.CodiceRep, "UQ__Reparto__8ECE59A5D56A6585").IsUnique();

            entity.Property(e => e.RepartoId).HasColumnName("repartoId");
            entity.Property(e => e.CodiceRep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice_rep");
            entity.Property(e => e.NomeRep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_rep");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
