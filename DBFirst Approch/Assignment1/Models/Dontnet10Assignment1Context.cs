using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models;

public partial class Dontnet10Assignment1Context : DbContext
{
    public Dontnet10Assignment1Context()
    {
    }

    public Dontnet10Assignment1Context(DbContextOptions<Dontnet10Assignment1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<HealthcareAssistant> HealthcareAssistants { get; set; }

    public virtual DbSet<Multimedicine> Multimedicines { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<TreatmentSchedule> TreatmentSchedules { get; set; }
    public virtual DbSet<patientreport> Patientreports { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC0395\\MSSQL2019;Database=Dontnet10Assignment1;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED8DF56444");

            entity.Property(e => e.DepartmentId).ValueGeneratedNever();
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EBFAA29F5F6");

            entity.Property(e => e.DoctorId).ValueGeneratedNever();
            entity.Property(e => e.DoctorGender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DoctorName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Department).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Doctors__Departm__267ABA7A");
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity.HasKey(e => e.DrugsId).HasName("PK__Drugs__96604FB0092F1009");

            entity.Property(e => e.DrugsId).ValueGeneratedNever();
            entity.Property(e => e.DrugsName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HealthcareAssistant>(entity =>
        {
            entity.HasKey(e => e.HealthcareAssistantsId).HasName("PK__Healthca__A74E8EC890C5B9FB");

            entity.Property(e => e.HealthcareAssistantsId)
                .ValueGeneratedNever()
                .HasColumnName("HealthcareAssistantsID");
            entity.Property(e => e.HealthcareAssistantsName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Department).WithMany(p => p.HealthcareAssistants)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Healthcar__Depar__2B3F6F97");

            entity.HasOne(d => d.Patient).WithMany(p => p.HealthcareAssistants)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Healthcar__Patie__2C3393D0");
        });

        modelBuilder.Entity<Multimedicine>(entity =>
        {
            entity.HasKey(e => e.MultimedicineId).HasName("PK__Multimed__0666664D135790D8");

            entity.ToTable("Multimedicine");

            entity.Property(e => e.MultimedicineId).ValueGeneratedNever();
            entity.Property(e => e.MultimedicineEattime)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Drugs).WithMany(p => p.Multimedicines)
                .HasForeignKey(d => d.DrugsId)
                .HasConstraintName("FK__Multimedi__Drugs__35BCFE0A");

            entity.HasOne(d => d.TreatmentSchedule).WithMany(p => p.Multimedicines)
                .HasForeignKey(d => d.TreatmentScheduleId)
                .HasConstraintName("FK__Multimedi__Treat__34C8D9D1");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC366771D7A3F");

            entity.Property(e => e.PatientId).ValueGeneratedNever();
            entity.Property(e => e.PatientGender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TreatmentSchedule>(entity =>
        {
            entity.HasKey(e => e.TreatmentScheduleId).HasName("PK__Treatmen__CE60379C171A3B03");

            entity.ToTable("TreatmentSchedule");

            entity.Property(e => e.TreatmentScheduleId).ValueGeneratedNever();

            entity.HasOne(d => d.Doctor).WithMany(p => p.TreatmentSchedules)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__Treatment__Docto__31EC6D26");

            entity.HasOne(d => d.Patient).WithMany(p => p.TreatmentSchedules)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Treatment__Patie__30F848ED");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
