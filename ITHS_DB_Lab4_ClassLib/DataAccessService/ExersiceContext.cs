using ITHS_DB_Lab4_DbModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_ClassLib.DataAccessService
{
    public class ExersiceContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Running> Running { get; set; }
        public DbSet<Cycling> Cycling { get; set; }
        public DbSet<Swiming> Swiming { get; set; }
        public DbSet<Gear> Gear { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<SessionExercise> SessionExercise { get; set; }
        public DbSet<SessionGear> SessionGear { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=ITHS_DB_Lab4;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(e =>
            { 
                e.Property(en => en.FirstName).IsRequired();
                e.Property(en => en.FirstName).HasMaxLength(255);
                e.Property(en => en.LastName).IsRequired();
                e.Property(en => en.LastName).HasMaxLength(255);
            });

            modelBuilder.Entity<Session>(e =>
            {
                e.Property(en => en.Name).IsRequired();
                e.Property(en => en.Description).IsRequired();
                e.Property(en => en.Time).IsRequired();
            });

            modelBuilder.Entity<Exercise>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Gear>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<SessionGear>()
                .HasKey(s => new { s.SessionId, s.GearId });

            modelBuilder.Entity<SessionExercise>()
                .Property(e => e.PainLevel)
                .HasDefaultValue(5);
        }

    }
}
