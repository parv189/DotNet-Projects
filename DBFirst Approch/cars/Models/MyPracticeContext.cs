using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cars.Models;

public partial class MyPracticeContext : DbContext
{
    public MyPracticeContext()
    {
    }

    public MyPracticeContext(DbContextOptions<MyPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Cource> Cources { get; set; }

    public virtual DbSet<Destributer> Destributers { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<Honda> Honda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC0404\\MSSQL2019;Database=MyPractice;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__car__4C9A0DB3A3F062E3");

            entity.ToTable("car");

            entity.Property(e => e.CarId)
                .ValueGeneratedNever()
                .HasColumnName("car_id");
            entity.Property(e => e.ModelName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("model_name");
            entity.Property(e => e.SellerId).HasColumnName("seller_id");

            entity.HasOne(d => d.Seller).WithMany(p => p.Cars)
                .HasForeignKey(d => d.SellerId)
                .HasConstraintName("FK__car__seller_id__3C69FB99");
        });

        modelBuilder.Entity<Cource>(entity =>
        {
            entity.HasKey(e => e.CourceId).HasName("PK__cources__54C9ADCA83860BB3");

            entity.ToTable("cources");

            entity.Property(e => e.CourceId)
                .ValueGeneratedNever()
                .HasColumnName("cource_id");
            entity.Property(e => e.CourceName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cource_name");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");

            entity.HasOne(d => d.CourceNavigation).WithOne(p => p.Cource)
                .HasForeignKey<Cource>(d => d.CourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cources__cource___34C8D9D1");
        });

        modelBuilder.Entity<Destributer>(entity =>
        {
            entity.HasKey(e => e.DestributerId).HasName("PK__destribu__2C1BFDF719D7C925");

            entity.ToTable("destributer");

            entity.Property(e => e.DestributerId)
                .ValueGeneratedNever()
                .HasColumnName("destributer_id");
            entity.Property(e => e.BillNo).HasColumnName("bill_no");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CompenyName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("compeny_name");
            entity.Property(e => e.TransportId).HasColumnName("transport_id");
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.HasKey(e => e.SellerId).HasName("PK__seller__780A0A97C8D8DF98");

            entity.ToTable("seller");

            entity.Property(e => e.SellerId)
                .ValueGeneratedNever()
                .HasColumnName("seller_id");
            entity.Property(e => e.DistributerId).HasColumnName("distributer_id");

            entity.HasOne(d => d.Distributer).WithMany(p => p.Sellers)
                .HasForeignKey(d => d.DistributerId)
                .HasConstraintName("FK__seller__distribu__398D8EEE");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__teacher__03AE777E4DA6775D");

            entity.ToTable("teacher");

            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("teacher_id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("subject_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
