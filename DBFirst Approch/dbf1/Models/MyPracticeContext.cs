using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dbf1.Models;

public partial class MyPracticeContext : DbContext
{
    public MyPracticeContext()
    {
    }

    public MyPracticeContext(DbContextOptions<MyPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cource> Cources { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC0404\\MSSQL2019;Database=MyPractice;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
