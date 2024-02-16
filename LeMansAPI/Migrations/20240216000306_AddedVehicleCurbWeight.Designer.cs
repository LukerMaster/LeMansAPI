﻿// <auto-generated />
using System;
using LeMansAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LeMansAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240216000306_AddedVehicleCurbWeight")]
    partial class AddedVehicleCurbWeight
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LeMansAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("CurbWeightKg")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("PeakPowerKw")
                        .HasColumnType("real");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("LeMansAPI.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RaceEntryResultId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RaceEntryResultId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("LeMansAPI.Models.PitStop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("LitersRefueled")
                        .HasColumnType("real");

                    b.Property<int?>("NewDriverId")
                        .HasColumnType("integer");

                    b.Property<string>("NotesOfRepairs")
                        .HasColumnType("text");

                    b.Property<int>("NumOfTiresChanged")
                        .HasColumnType("integer");

                    b.Property<string>("OtherNotes")
                        .HasColumnType("text");

                    b.Property<int?>("RaceEntryResultId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NewDriverId");

                    b.HasIndex("RaceEntryResultId");

                    b.ToTable("PitStops");
                });

            modelBuilder.Entity("LeMansAPI.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("LeMansAPI.Models.RaceEntryResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<double>("MetersDriven")
                        .HasColumnType("double precision");

                    b.Property<int>("RaceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceEntryResults");
                });

            modelBuilder.Entity("LeMansAPI.Models.Driver", b =>
                {
                    b.HasOne("LeMansAPI.Models.RaceEntryResult", null)
                        .WithMany("Drivers")
                        .HasForeignKey("RaceEntryResultId");
                });

            modelBuilder.Entity("LeMansAPI.Models.PitStop", b =>
                {
                    b.HasOne("LeMansAPI.Models.Driver", "NewDriver")
                        .WithMany()
                        .HasForeignKey("NewDriverId");

                    b.HasOne("LeMansAPI.Models.RaceEntryResult", null)
                        .WithMany("PitStops")
                        .HasForeignKey("RaceEntryResultId");

                    b.Navigation("NewDriver");
                });

            modelBuilder.Entity("LeMansAPI.Models.RaceEntryResult", b =>
                {
                    b.HasOne("LeMansAPI.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeMansAPI.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("LeMansAPI.Models.RaceEntryResult", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("PitStops");
                });
#pragma warning restore 612, 618
        }
    }
}