using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Models
{
    public class NaukriContext : DbContext
    {
        public NaukriContext() { }
        public NaukriContext(DbContextOptions<NaukriContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Jobapply> JobsApply { get; set; }
        public DbSet<Plan> plans { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Educationdegree> educationdegrees { get; set; }
        public DbSet<Educationhsc> educationhscs { get;set; }
        public DbSet<Educationssc> educationsscs { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<UserCompanyExperience> UserCompanyExperiences { get; set; }
        public DbSet<UserLocation> userLocations { get; set; }
        public DbSet<UserProject> userProjects { get; set; } 
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer("Server=PC0395\\MSSQL2019;Database=naukridatabase;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
                        .HasOne(m => m.Users)
                        .WithOne(t=>t.UserProfiles)
                        .HasForeignKey<UserProfile>(m => m.UserProfileId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Educationssc>()
                   .HasOne(m => m.UserProfiles)
                   .WithOne(t => t.educationsscs)
                   .HasForeignKey<Educationssc>(m => m.EducationsscId)
                   .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Educationhsc>()
                      .HasOne(m => m.UserProfiles)
                      .WithOne(t => t.educationhscs)
                      .HasForeignKey<Educationhsc>(m => m.EducationhscId)
                      .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Educationdegree>()
                       .HasOne(m => m.UserProfiles)
                       .WithOne(t => t.educationdegrees)
                       .HasForeignKey<Educationdegree>(m => m.EducationdegreeId)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserLocation>()
                     .HasOne(m => m.UserProfiles)
                     .WithOne(t => t.userLocations)
                     .HasForeignKey<UserLocation>(m => m.UserLocationId)
                     .OnDelete(DeleteBehavior.Restrict);
        }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             *//*modelBuilder.Entity<User>()
                         .HasOne(m => m.Users1)
                         .WithMany()
                         .HasForeignKey(m => m.UserCreateId)
                         .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<User>()
                        .HasOne(m => m.Users2)
                        .WithMany()
                        .HasForeignKey(m => m.UserModifyId)
                        .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Company>()
                        .HasOne(m => m.Users1)
                        .WithOne(m => m.companies1)
                        .HasForeignKey<Company>(m => m.CompanyCreateId)
                        .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Company>()
                        .HasOne(m => m.Users2)
                        .WithOne(m => m.companies2)
                        .HasForeignKey<Company>(m => m.CompanyModifyId)
                        .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Job>()
                       .HasOne(m => m.Users1)
                       .WithOne(m => m.Job1)
                       .HasForeignKey<Job>(m => m.JobCreateId)
                       .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Job>()
                        .HasOne(m => m.Users2)
                        .WithOne(m => m.Job2)
                        .HasForeignKey<Job>(m => m.JobModifyId)
                        .OnDelete(DeleteBehavior.Restrict);*//*
         }*/

    }
}
