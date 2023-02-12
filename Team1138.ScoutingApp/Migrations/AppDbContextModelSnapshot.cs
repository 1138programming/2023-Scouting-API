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
                    b.Property<int>("MatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatchID"));

                    b.Property<int>("Competition")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionID")
                        .HasColumnType("int");

                    b.Property<int>("MatchNumber")
                        .HasColumnType("int");

                    b.HasKey("MatchID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.MatchResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("ActivationBonus")
                        .HasColumnType("bit");

                    b.Property<bool?>("AutonDocking")
                        .HasColumnType("bit");

                    b.Property<string>("AutonNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AutonWinner")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousControlPoints")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousHighCubeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousLowCubeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("AutonomousMidCubeMiss")
                        .HasColumnType("int");

                    b.Property<bool?>("CoopertitionBonus")
                        .HasColumnType("bit");

                    b.Property<int?>("DCControlPoints")
                        .HasColumnType("int");

                    b.Property<bool?>("DCDocking")
                        .HasColumnType("bit");

                    b.Property<bool?>("DCEngaged")
                        .HasColumnType("bit");

                    b.Property<int?>("DCHighConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCHighConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCHighConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DCHighCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCHighCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCHighCubeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCLowCubeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidConeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidConeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidConeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidCubeAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidCubeHit")
                        .HasColumnType("int");

                    b.Property<int?>("DCMidCubeMiss")
                        .HasColumnType("int");

                    b.Property<int?>("DPR")
                        .HasColumnType("int");

                    b.Property<bool?>("Engaged")
                        .HasColumnType("bit");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("MatchNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("MobilityBonus")
                        .HasColumnType("bit");

                    b.Property<int?>("OPR")
                        .HasColumnType("int");

                    b.Property<bool?>("SustainabilityBonus")
                        .HasColumnType("bit");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatchResult");
                });

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.PitScoutingResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChargingStationActivation")
                        .HasColumnType("int");

                    b.Property<int?>("ChargingStationPosition")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<bool?>("CoopNodeTypeHighCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeHighCube")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeHybridCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeHybridCube")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeMidCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("CoopNodeTypeMidCube")
                        .HasColumnType("bit");

                    b.Property<int?>("DriverControlGamePiecesUsed")
                        .HasColumnType("int");

                    b.Property<int?>("DrivetrainMotorNum")
                        .HasColumnType("int");

                    b.Property<int?>("EndGameDockingActivation")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosFL")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosFR")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosML")
                        .HasColumnType("int");

                    b.Property<int?>("GamePieceStartingPosMR")
                        .HasColumnType("int");

                    b.Property<int?>("MobilityPoints")
                        .HasColumnType("int");

                    b.Property<int?>("MotorType")
                        .HasColumnType("int");

                    b.Property<bool?>("NodeTypeHigh")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHighCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHighCube")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHybridCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHybridCube")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeHybridOrFloor")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeMid")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeMidCone")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeMidCube")
                        .HasColumnType("bit");

                    b.Property<bool?>("NodeTypeNone")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Team1138.ScoutingApp.Data.Entities.PitScoutingResult", b =>
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
