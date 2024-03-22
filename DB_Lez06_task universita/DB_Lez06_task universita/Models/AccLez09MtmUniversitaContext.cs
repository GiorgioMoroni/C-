using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_Lez06_task_universita.Models;

public partial class AccLez09MtmUniversitaContext : DbContext
{
    public AccLez09MtmUniversitaContext()
    {
    }

    public AccLez09MtmUniversitaContext(DbContextOptions<AccLez09MtmUniversitaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Esame> Esames { get; set; }

    public virtual DbSet<Studente> Studentes { get; set; }

    public virtual DbSet<StudenteEsame> StudenteEsames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez09_mtm_universita;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Esame>(entity =>
        {
            entity.HasKey(e => e.EsameId).HasName("PK__Esame__C5EF3E09EFCDA43E");

            entity.ToTable("Esame");

            entity.Property(e => e.EsameId).HasColumnName("esameID");
            entity.Property(e => e.Crediti).HasColumnName("crediti");
            entity.Property(e => e.DataEsame).HasColumnName("data_esame");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        modelBuilder.Entity<Studente>(entity =>
        {
            entity.HasKey(e => e.StudenteId).HasName("PK__Studente__20A4EC91159E5EB9");

            entity.ToTable("Studente");

            entity.HasIndex(e => e.Matricola, "UQ__Studente__2C2751BA7825DA77").IsUnique();

            entity.Property(e => e.StudenteId).HasColumnName("studenteID");
            entity.Property(e => e.Matricola)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nominativo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nominativo");
        });

        modelBuilder.Entity<StudenteEsame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Studente_Esame");

            entity.HasIndex(e => new { e.StudenteRif, e.EsameRif }, "UQ__Studente__C715ED0A9A24F300").IsUnique();

            entity.Property(e => e.EsameRif).HasColumnName("esameRIF");
            entity.Property(e => e.StudenteRif).HasColumnName("studenteRIF");

            entity.HasOne(d => d.EsameRifNavigation).WithMany()
                .HasForeignKey(d => d.EsameRif)
                .HasConstraintName("FK__Studente___esame__3E52440B");

            entity.HasOne(d => d.StudenteRifNavigation).WithMany()
                .HasForeignKey(d => d.StudenteRif)
                .HasConstraintName("FK__Studente___stude__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
