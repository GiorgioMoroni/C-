using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP_lez02_EF_libreria.Models;

public partial class AccLez32ApiContext : DbContext
{
    public AccLez32ApiContext()
    {
    }

    public AccLez32ApiContext(DbContextOptions<AccLez32ApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez32_API;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libro__18C65F4B8C2AF597");

            entity.ToTable("Libro");

            entity.Property(e => e.LibroId).HasColumnName("libroID");
            entity.Property(e => e.Autore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("autore");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Descrizione)
                .HasColumnType("text")
                .HasColumnName("descrizione");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzo");
            entity.Property(e => e.Quantita)
                .HasDefaultValue(0)
                .HasColumnName("quantita");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
