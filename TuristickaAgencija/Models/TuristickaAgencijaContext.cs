using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration; 
namespace TuristickaAgencija.Models;

public partial class TuristickaAgencijaContext : DbContext
{
    public TuristickaAgencijaContext()
    {
    }

    public TuristickaAgencijaContext(DbContextOptions<TuristickaAgencijaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agencija> Agencijas { get; set; }

    public virtual DbSet<Autobus> Autobus { get; set; }

    public virtual DbSet<Automobil> Automobils { get; set; }

    public virtual DbSet<Destinacija> Destinacijas { get; set; }

    public virtual DbSet<Klijent> Klijents { get; set; }

    public virtual DbSet<Nabavlja> Nabavljas { get; set; }

    public virtual DbSet<Nudi> Nudis { get; set; }

    public virtual DbSet<Obuhvata> Obuhvata { get; set; }

    public virtual DbSet<PrevoznoSredstvo> PrevoznoSredstvos { get; set; }

    public virtual DbSet<Putovanje> Putovanjes { get; set; }

    public virtual DbSet<Rezervise> Rezervises { get; set; }

    public virtual DbSet<SeDolazi> SeDolazis { get; set; }

    public virtual DbSet<Smestaj> Smestajs { get; set; }

    public virtual DbSet<Tipsmestaja> Tipsmestajas { get; set; }

    public virtual DbSet<Vodic> Vodics { get; set; }

    public virtual DbSet<vrstaAutomobila> vrstaAutomobilas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TuristickaAgencijaConnectionString"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agencija>(entity =>
        {
            entity.HasKey(e => e.IdAg).HasName("AG_PK");

            entity.ToTable("AGENCIJA");

            entity.Property(e => e.AdrAg)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NazAg)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Autobus>(entity =>
        {
            entity.HasKey(e => e.IdPrzs).HasName("PrevoznoSredstvo_PK_AUTOBUS");

            entity.ToTable("AUTOBUS");

            entity.HasIndex(e => e.RegBrBus, "AUTOBUS_UN").IsUnique();

            entity.Property(e => e.IdPrzs).ValueGeneratedNever();
            entity.Property(e => e.RegBrBus)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPrzsNavigation).WithOne(p => p.Autobu)
                .HasForeignKey<Autobus>(d => d.IdPrzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AUTOBUS_FK");
        });

        modelBuilder.Entity<Automobil>(entity =>
        {
            entity.HasKey(e => e.IdPrzs).HasName("AUTOMOBIL_PK");

            entity.ToTable("AUTOMOBIL");

            entity.HasIndex(e => e.RegBrAuto, "AUTOMOBIL_UN").IsUnique();

            entity.Property(e => e.IdPrzs).ValueGeneratedNever();
            entity.Property(e => e.RegBrAuto)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPrzsNavigation).WithOne(p => p.Automobil)
                .HasForeignKey<Automobil>(d => d.IdPrzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AUTOMOBIL_FK_PRZS");

            entity.HasOne(d => d.IdVrsteNavigation).WithMany(p => p.Automobils)
                .HasForeignKey(d => d.IdVrste)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AUTOMOBIL_FK_VRSTA");
        });

        modelBuilder.Entity<Destinacija>(entity =>
        {
            entity.HasKey(e => e.IdDest).HasName("DEST_PK");

            entity.ToTable("DESTINACIJA");

            entity.Property(e => e.NazDest)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Klijent>(entity =>
        {
            entity.HasKey(e => e.IdK).HasName("K_PK");

            entity.ToTable("KLIJENT");

            entity.HasIndex(e => e.JmbgK, "K_UN").IsUnique();

            entity.Property(e => e.BrK)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ImeK)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JmbgK)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.PrzK)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nabavlja>(entity =>
        {
            entity.HasKey(e => e.IdNabavlja).HasName("NABAVLJA_PK");

            entity.ToTable("NABAVLJA");

            entity.HasOne(d => d.IdAgNavigation).WithMany(p => p.Nabavljas)
                .HasForeignKey(d => d.IdAg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NABAVLJA_FK_AG");

            entity.HasOne(d => d.IdPrzsNavigation).WithMany(p => p.Nabavljas)
                .HasForeignKey(d => d.IdPrzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NABAVLJA_FK_PRZS");
        });

        modelBuilder.Entity<Nudi>(entity =>
        {
            entity.HasKey(e => e.IdNudi).HasName("NUDI_PK");

            entity.ToTable("NUDI");

            entity.HasOne(d => d.IdAgNavigation).WithMany(p => p.Nudis)
                .HasForeignKey(d => d.IdAg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NUDI_FK_AG");

            entity.HasOne(d => d.IdPutaNavigation).WithMany(p => p.Nudis)
                .HasForeignKey(d => d.IdPuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NUDI_FK_PUT");
        });

        modelBuilder.Entity<Obuhvata>(entity =>
        {
            entity.HasKey(e => e.IdObuhvata).HasName("OBUHVATA_PK");

            entity.ToTable("OBUHVATA");

            entity.HasOne(d => d.IdDestNavigation).WithMany(p => p.Obuhvata)
                .HasForeignKey(d => d.IdDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OBUHVATA_FK_DEST");

            entity.HasOne(d => d.IdPutaNavigation).WithMany(p => p.Obuhvata)
                .HasForeignKey(d => d.IdPuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OBUHVATA_FK_PUT");
        });

        modelBuilder.Entity<PrevoznoSredstvo>(entity =>
        {
            entity.HasKey(e => e.IdPrzs).HasName("PrevoznoSredstvo_PK");

            entity.ToTable("PrevoznoSredstvo");

            entity.Property(e => e.KategorijaPrzs)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Putovanje>(entity =>
        {
            entity.HasKey(e => e.IdPuta).HasName("PUT_PK");

            entity.ToTable("PUTOVANJE");

            entity.Property(e => e.DatumPol).HasColumnType("date");
            entity.Property(e => e.DatumPov).HasColumnType("date");
            entity.Property(e => e.NazPuta)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rezervise>(entity =>
        {
            entity.HasKey(e => new { e.IdK, e.IdAg, e.IdPuta }).HasName("REZERVISE_PK");

            entity.ToTable("REZERVISE");

            entity.HasOne(d => d.IdAgNavigation).WithMany(p => p.Rezervises)
                .HasForeignKey(d => d.IdAg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REZERVISE_FK_AG");

            entity.HasOne(d => d.IdKNavigation).WithMany(p => p.Rezervises)
                .HasForeignKey(d => d.IdK)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REZERVISE_FK_KLIJENT");

            entity.HasOne(d => d.IdPrzsNavigation).WithMany(p => p.Rezervises)
                .HasForeignKey(d => d.IdPrzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REZERVISE_FK_PRZS");

            entity.HasOne(d => d.IdPutaNavigation).WithMany(p => p.Rezervises)
                .HasForeignKey(d => d.IdPuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REZERVISE_FK_PUT");
        });

        modelBuilder.Entity<SeDolazi>(entity =>
        {
            entity.HasKey(e => e.IdSeDolazi).HasName("SeDolazi_PK");

            entity.ToTable("SeDolazi");

            entity.HasOne(d => d.IdDestNavigation).WithMany(p => p.SeDolazis)
                .HasForeignKey(d => d.IdDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SeDolazi_FK_DEST");

            entity.HasOne(d => d.IdPrzsNavigation).WithMany(p => p.SeDolazis)
                .HasForeignKey(d => d.IdPrzs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SeDolazi_FK_PRZS");
        });

        modelBuilder.Entity<Smestaj>(entity =>
        {
            entity.HasKey(e => e.IdSm).HasName("SMESTAJ_PK");

            entity.ToTable("SMESTAJ");

            entity.Property(e => e.NazSm)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDestNavigation).WithMany(p => p.Smestajs)
                .HasForeignKey(d => d.IdDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SMESTAJ_FK_DEST");

            entity.HasOne(d => d.IdTipaNavigation).WithMany(p => p.Smestajs)
                .HasForeignKey(d => d.IdTipa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SMESTAJ_FK_TIP");
        });

        modelBuilder.Entity<Tipsmestaja>(entity =>
        {
            entity.HasKey(e => e.IdTipa).HasName("TIPSMESTAJA_PK");

            entity.ToTable("TIPSMESTAJA");

            entity.Property(e => e.NazTipa)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vodic>(entity =>
        {
            entity.HasKey(e => e.IdVod).HasName("VODIC_PK");

            entity.ToTable("VODIC");

            entity.HasIndex(e => e.JmbgVod, "V_UN").IsUnique();

            entity.Property(e => e.BrVod)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.IdAg).HasColumnName("idAg");
            entity.Property(e => e.ImeVod)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JmbgVod)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.PrzVod)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAgNavigation).WithMany(p => p.Vodics)
                .HasForeignKey(d => d.IdAg)
                .HasConstraintName("VODIC_FK");
        });

        modelBuilder.Entity<vrstaAutomobila>(entity =>
        {
            entity.HasKey(e => e.IdVrste).HasName("vrstaAutomobila_PK");

            entity.ToTable("vrstaAutomobila");

            entity.Property(e => e.NazVrste)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
