using ITHS_DB_Lab4_DbModel.DataAccess;
using ITHS_DB_Lab4_DbModel.DataAccess.Configurations;
using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_ClassLib.DataAccess
{
    public class ExersiceContext : DbContext
    {
        public ExersiceContext(DbContextOptions<ExersiceContext> options) : base(options) { }
        public ExersiceContext() { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Running> Running { get; set; }
        public DbSet<Cycling> Cycling { get; set; }
        public DbSet<Swiming> Swiming { get; set; }
        public DbSet<Gear> Gear { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<SessionExercise> SessionExercise { get; set; }
        public DbSet<SessionGear> SessionGear { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
            modelBuilder.ApplyConfiguration(new GearConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new SessionExerciseConfiguration());
            modelBuilder.ApplyConfiguration(new SessionGearConfiguration());
        }

    }
}
