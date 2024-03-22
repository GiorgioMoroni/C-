using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_Lez07_Task_Uni.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez09_mtm_universita;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Esame>(entity =>
        {
            entity.HasKey(e => e.EsameId).HasName("PK__Esame__C5EF3E0933C360C0");

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
            entity.HasKey(e => e.StudenteId).HasName("PK__Studente__20A4EC91D723193D");

            entity.ToTable("Studente");

            entity.HasIndex(e => e.Matricola, "UQ__Studente__2C2751BAD276AF33").IsUnique();

            entity.Property(e => e.StudenteId).HasColumnName("studenteID");
            entity.Property(e => e.Matricola)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nominativo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nominativo");

            entity.HasMany(d => d.EsameRifs).WithMany(p => p.StudenteRifs)
                .UsingEntity<Dictionary<string, object>>(
                    "StudenteEsame",
                    r => r.HasOne<Esame>().WithMany()
                        .HasForeignKey("EsameRif")
                        .HasConstraintName("FK__Studente___esame__5070F446"),
                    l => l.HasOne<Studente>().WithMany()
                        .HasForeignKey("StudenteRif")
                        .HasConstraintName("FK__Studente___stude__4F7CD00D"),
                    j =>
                    {
                        j.HasKey("StudenteRif", "EsameRif").HasName("PK__Studente__C715ED0B26076017");
                        j.ToTable("Studente_Esame");
                        j.IndexerProperty<int>("StudenteRif").HasColumnName("studenteRIF");
                        j.IndexerProperty<int>("EsameRif").HasColumnName("esameRIF");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
