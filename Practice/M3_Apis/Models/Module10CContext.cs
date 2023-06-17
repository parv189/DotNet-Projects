using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace M3_Apis.Models
{
    public partial class Module10CContext : DbContext
    {
        public Module10CContext()
        {
        }

        public Module10CContext(DbContextOptions<Module10CContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Drug> Drugs { get; set; } = null!;
        public virtual DbSet<Healthcare> Healthcares { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;

        public virtual DbSet<Query1>Query1 { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0404\\MSSQL2019;Database=Module10C#;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctors");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DId).HasColumnName("d_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DId)
                    .HasConstraintName("FK__doctors__d_ID__412EB0B6");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("drugs");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Timing)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("timing");
            });

            modelBuilder.Entity<Healthcare>(entity =>
            {
                entity.ToTable("healthcare");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DId).HasColumnName("d_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Healthcares)
                    .HasForeignKey(d => d.DId)
                    .HasConstraintName("FK__healthcare__d_ID__47DBAE45");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patients");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DeptId).HasColumnName("dept_ID");

                entity.Property(e => e.DoctId).HasColumnName("doct_ID");

                entity.Property(e => e.DrugId).HasColumnName("drug_id");

                entity.Property(e => e.HealthId).HasColumnName("health_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__patients__dept_I__4E88ABD4");

                entity.HasOne(d => d.Doct)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DoctId)
                    .HasConstraintName("FK__patients__doct_I__4D94879B");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK__patients__drug_i__5070F446");

                entity.HasOne(d => d.Health)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.HealthId)
                    .HasConstraintName("FK__patients__health__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
