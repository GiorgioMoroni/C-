using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskChat.Models;

public partial class TaskChatContext : DbContext
{
    public TaskChatContext()
    {
    }

    public TaskChatContext(DbContextOptions<TaskChatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Utente> Utentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=TaskChat;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utente__CA5C22538B76FC0C");

            entity.ToTable("Utente");

            entity.HasIndex(e => e.Password, "UQ__Utente__6E2DBEDEE7A920F9").IsUnique();

            entity.HasIndex(e => e.NomeUtente, "UQ__Utente__8A3C9FDF37F25918").IsUnique();

            entity.Property(e => e.UtenteId).HasColumnName("utenteID");
            entity.Property(e => e.NomeUtente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeUtente");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
