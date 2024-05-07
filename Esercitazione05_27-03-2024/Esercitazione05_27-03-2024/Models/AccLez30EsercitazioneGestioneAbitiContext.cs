using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Esercitazione05_27_03_2024.Models;

public partial class AccLez30EsercitazioneGestioneAbitiContext : DbContext
{
    public AccLez30EsercitazioneGestioneAbitiContext()
    {
    }

    public AccLez30EsercitazioneGestioneAbitiContext(DbContextOptions<AccLez30EsercitazioneGestioneAbitiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Ordine> Ordines { get; set; }

    public virtual DbSet<Prezzo> Prezzos { get; set; }

    public virtual DbSet<Prodotto> Prodottos { get; set; }

    public virtual DbSet<Utente> Utentes { get; set; }

    public virtual DbSet<Variazione> Variaziones { get; set; }

    public virtual DbSet<VariazioneOrdine> VariazioneOrdines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez30_esercitazione_gestione_abiti;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240C6BE49E7A");

            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Ordine>(entity =>
        {
            entity.HasKey(e => e.IdOrdine).HasName("PK__Ordine__569A3E91D42BB442");

            entity.ToTable("Ordine");

            entity.Property(e => e.IdOrdine).HasColumnName("idOrdine");
            entity.Property(e => e.DataOrdine).HasColumnName("data_ordine");
            entity.Property(e => e.QuantitaOrdinata).HasColumnName("quantita_ordinata");
            entity.Property(e => e.UtenteRif).HasColumnName("utenteRIF");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Ordines)
                .HasForeignKey(d => d.UtenteRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ordine__utenteRI__00200768");
        });

        modelBuilder.Entity<Prezzo>(entity =>
        {
            entity.HasKey(e => e.IdPrezzo).HasName("PK__Prezzo__912F93056388A70C");

            entity.ToTable("Prezzo");

            entity.Property(e => e.IdPrezzo).HasColumnName("idPrezzo");
            entity.Property(e => e.DataFine)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("data_fine");
            entity.Property(e => e.DataInizio)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("data_inizio");
            entity.Property(e => e.Prezzo1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzo");
            entity.Property(e => e.PrezzoSconto)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prezzo_sconto");
            entity.Property(e => e.VariazioneRif).HasColumnName("variazioneRIF");

            entity.HasOne(d => d.VariazioneRifNavigation).WithMany(p => p.Prezzos)
                .HasForeignKey(d => d.VariazioneRif)
                .HasConstraintName("FK__Prezzo__variazio__7C4F7684");
        });

        modelBuilder.Entity<Prodotto>(entity =>
        {
            entity.HasKey(e => e.IdProdotto).HasName("PK__Prodotto__0A9870D970F59D2C");

            entity.ToTable("Prodotto");

            entity.Property(e => e.IdProdotto).HasColumnName("idProdotto");
            entity.Property(e => e.CategoriaRif).HasColumnName("categoriaRIF");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modello)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modello");

            entity.HasOne(d => d.CategoriaRifNavigation).WithMany(p => p.Prodottos)
                .HasForeignKey(d => d.CategoriaRif)
                .HasConstraintName("FK__Prodotto__catego__72C60C4A");
        });

        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.IdUtente).HasName("PK__Utente__11EA834F06234B00");

            entity.ToTable("Utente");

            entity.HasIndex(e => e.Telefono, "UQ__Utente__2A16D945475B95FD").IsUnique();

            entity.HasIndex(e => e.Nome, "UQ__Utente__6F71C0DCC3AB93A5").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Utente__AB6E6164E7681E12").IsUnique();

            entity.Property(e => e.IdUtente).HasColumnName("idUtente");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefono)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Variazione>(entity =>
        {
            entity.HasKey(e => e.IdVariazione).HasName("PK__Variazio__05D8F994F702D499");

            entity.ToTable("Variazione");

            entity.Property(e => e.IdVariazione).HasColumnName("idVariazione");
            entity.Property(e => e.Colore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("colore");
            entity.Property(e => e.ProdottoRif).HasColumnName("prodottoRIF");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.Taglia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("taglia");

            entity.HasOne(d => d.ProdottoRifNavigation).WithMany(p => p.Variaziones)
                .HasForeignKey(d => d.ProdottoRif)
                .HasConstraintName("FK__Variazion__prodo__76969D2E");
        });

        modelBuilder.Entity<VariazioneOrdine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Variazione_Ordine");

            entity.Property(e => e.OrdineRif).HasColumnName("ordineRIF");
            entity.Property(e => e.VariazioneRif).HasColumnName("variazioneRIF");

            entity.HasOne(d => d.OrdineRifNavigation).WithMany()
                .HasForeignKey(d => d.OrdineRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Variazion__ordin__02084FDA");

            entity.HasOne(d => d.VariazioneRifNavigation).WithMany()
                .HasForeignKey(d => d.VariazioneRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Variazion__varia__02FC7413");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
