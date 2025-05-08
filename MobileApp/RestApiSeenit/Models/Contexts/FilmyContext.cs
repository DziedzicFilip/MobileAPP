using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestApiSeenit.Models;

namespace RestApiSeenit.Models.Contexts
{
    public partial class FilmyContext : DbContext
    {
        public FilmyContext()
        {
        }

        public FilmyContext(DbContextOptions<FilmyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<ListaObejrzane> ListaObejrzanes { get; set; } = null!;
        public virtual DbSet<ListaObserwowane> ListaObserwowanes { get; set; } = null!;
        public virtual DbSet<Odcinek> Odcineks { get; set; } = null!;
        public virtual DbSet<RecenzjaFilmu> RecenzjaFilmus { get; set; } = null!;
        public virtual DbSet<RecenzjaOdcinka> RecenzjaOdcinkas { get; set; } = null!;
        public virtual DbSet<RecenzjaSerialu> RecenzjaSerialus { get; set; } = null!;
        public virtual DbSet<Rodzaj> Rodzajs { get; set; } = null!;
        public virtual DbSet<Serial> Serials { get; set; } = null!;
        public virtual DbSet<Ulubione> Ulubiones { get; set; } = null!;
        public virtual DbSet<Uzytkownik> Uzytkowniks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=SeenIT;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasOne(d => d.Rodzaj)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.RodzajId)
                    .HasConstraintName("FK__Film__RodzajId__29572725");
            });

            modelBuilder.Entity<ListaObejrzane>(entity =>
            {
                entity.Property(e => e.DataDodania).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.ListaObejrzanes)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__ListaObej__FilmI__440B1D61");

                entity.HasOne(d => d.Serial)
                    .WithMany(p => p.ListaObejrzanes)
                    .HasForeignKey(d => d.SerialId)
                    .HasConstraintName("FK__ListaObej__Seria__44FF419A");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.ListaObejrzanes)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__ListaObej__Uzytk__4316F928");
            });

            modelBuilder.Entity<ListaObserwowane>(entity =>
            {
                entity.Property(e => e.DataDodania).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.ListaObserwowanes)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__ListaObse__FilmI__49C3F6B7");

                entity.HasOne(d => d.Serial)
                    .WithMany(p => p.ListaObserwowanes)
                    .HasForeignKey(d => d.SerialId)
                    .HasConstraintName("FK__ListaObse__Seria__4AB81AF0");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.ListaObserwowanes)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__ListaObse__Uzytk__48CFD27E");
            });

            modelBuilder.Entity<Odcinek>(entity =>
            {
                entity.HasOne(d => d.Serial)
                    .WithMany(p => p.Odcineks)
                    .HasForeignKey(d => d.SerialId)
                    .HasConstraintName("FK__Odcinek__SerialI__2F10007B");
            });

            modelBuilder.Entity<RecenzjaFilmu>(entity =>
            {
                entity.Property(e => e.Data).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.RecenzjaFilmus)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__RecenzjaF__FilmI__34C8D9D1");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.RecenzjaFilmus)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__RecenzjaF__Uzytk__33D4B598");
            });

            modelBuilder.Entity<RecenzjaOdcinka>(entity =>
            {
                entity.Property(e => e.Data).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Odcinek)
                    .WithMany(p => p.RecenzjaOdcinkas)
                    .HasForeignKey(d => d.OdcinekId)
                    .HasConstraintName("FK__RecenzjaO__Odcin__403A8C7D");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.RecenzjaOdcinkas)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__RecenzjaO__Uzytk__3F466844");
            });

            modelBuilder.Entity<RecenzjaSerialu>(entity =>
            {
                entity.Property(e => e.Data).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Serial)
                    .WithMany(p => p.RecenzjaSerialus)
                    .HasForeignKey(d => d.SerialId)
                    .HasConstraintName("FK__RecenzjaS__Seria__3A81B327");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.RecenzjaSerialus)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__RecenzjaS__Uzytk__398D8EEE");
            });

            modelBuilder.Entity<Serial>(entity =>
            {
                entity.HasOne(d => d.Rodzaj)
                    .WithMany(p => p.Serials)
                    .HasForeignKey(d => d.RodzajId)
                    .HasConstraintName("FK__Serial__RodzajId__2C3393D0");
            });

            modelBuilder.Entity<Ulubione>(entity =>
            {
                entity.Property(e => e.DataDodania).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Ulubiones)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__Ulubione__FilmId__4F7CD00D");

                entity.HasOne(d => d.Serial)
                    .WithMany(p => p.Ulubiones)
                    .HasForeignKey(d => d.SerialId)
                    .HasConstraintName("FK__Ulubione__Serial__5070F446");

                entity.HasOne(d => d.Uzytkownik)
                    .WithMany(p => p.Ulubiones)
                    .HasForeignKey(d => d.UzytkownikId)
                    .HasConstraintName("FK__Ulubione__Uzytko__4E88ABD4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
