﻿// <auto-generated />
using System;
using ITHS_DB_Lab4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITHS_DB_Lab4.Migrations
{
    [DbContext(typeof(ExersiceContext))]
    partial class ExersiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITHS_DB_Lab4.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Gear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Gear");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PersonId");

                    b.Property<float>("Time");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Session");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Session");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.SessionExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExerciseId");

                    b.Property<int?>("PainLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(5);

                    b.Property<int?>("Repetitions");

                    b.Property<int>("SessionId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionExercise");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.SessionGear", b =>
                {
                    b.Property<int>("SessionId");

                    b.Property<int>("GearId");

                    b.HasKey("SessionId", "GearId");

                    b.HasIndex("GearId");

                    b.ToTable("SessionGear");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Cycling", b =>
                {
                    b.HasBaseType("ITHS_DB_Lab4.Session");

                    b.HasDiscriminator().HasValue("Cycling");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Running", b =>
                {
                    b.HasBaseType("ITHS_DB_Lab4.Session");

                    b.HasDiscriminator().HasValue("Running");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Swiming", b =>
                {
                    b.HasBaseType("ITHS_DB_Lab4.Session");

                    b.HasDiscriminator().HasValue("Swiming");
                });

            modelBuilder.Entity("ITHS_DB_Lab4.Session", b =>
                {
                    b.HasOne("ITHS_DB_Lab4.Person", "Person")
                        .WithMany("Sessions")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITHS_DB_Lab4.SessionExercise", b =>
                {
                    b.HasOne("ITHS_DB_Lab4.Exercise", "Exercise")
                        .WithMany("SessionExercise")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITHS_DB_Lab4.Session", "Session")
                        .WithMany("SessionExercise")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITHS_DB_Lab4.SessionGear", b =>
                {
                    b.HasOne("ITHS_DB_Lab4.Gear", "Gear")
                        .WithMany("SessionGear")
                        .HasForeignKey("GearId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITHS_DB_Lab4.Session", "Session")
                        .WithMany("SessionGear")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
