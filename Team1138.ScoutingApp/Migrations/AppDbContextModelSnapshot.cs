﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team1138.ScoutingApp.Data;

#nullable disable

namespace Team1138.ScoutingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.Competition", b =>
                {
                    b.Property<int>("CompetitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompetitionID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CompetitionID");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.Match", b =>
                {
                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("MatchNumber")
                        .HasColumnType("int");

                    b.HasKey("CompetitionId", "MatchNumber");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.PitSoutingResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("CanDockOnChargingStation")
                        .HasColumnType("bit");

                    b.Property<bool?>("CanEngageOnChargingStation")
                        .HasColumnType("bit");

                    b.Property<bool?>("CantScoreNode")
                        .HasColumnType("bit");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<bool?>("CoopNodeTypeHigh")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeHybridOrFloor")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeMid")
                        .HasColumnType("bit");

                    b.Property<int?>("DrivetrainMotorNum")
                        .HasColumnType("int");

                    b.Property<int?>("EndGameDock")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosFL")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosFR")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosML")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosMR")
                        .HasColumnType("int");

                    b.Property<bool?>("NodeTypeHigh")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHybridOrFloor")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeMid")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumBatChargers")
                        .HasColumnType("int");

                    b.Property<int?>("NumBatteries")
                        .HasColumnType("int");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("TeamNumber");

                    b.ToTable("PitSoutingResults");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.Team", b =>
                {
                    b.Property<int>("TeamNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamNumber"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamNumber");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.Match", b =>
                {
                    b.HasOne("Team1138.ScoutingApp.Data.Entities.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.PitSoutingResult", b =>
                {
                    b.HasOne("Team1138.ScoutingApp.Data.Entities.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team1138.ScoutingApp.Data.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
