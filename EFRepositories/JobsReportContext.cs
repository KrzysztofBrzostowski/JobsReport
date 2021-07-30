using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace EFRepositories
{
    public class JobsReportContext : DbContext
    {
        public DbSet<JobReport> JobReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=(local)\SQLEXPRESS;Database=Zadania;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobReport>().ToTable("Jobs");

            modelBuilder.Entity<JobReport>()
                .Property(p => p.Id)
                .HasColumnName("ID");

            modelBuilder.Entity<JobReport>().Property(p => p.NazwaPrac)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<JobReport>().Property(p => p.NazwaUzytkownika)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<JobReport>().Property(p => p.NazwaLokalu)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
