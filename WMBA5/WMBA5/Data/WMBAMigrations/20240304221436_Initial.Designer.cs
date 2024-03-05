﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMBA5.Data;

#nullable disable

namespace WMBA5.Data.WMBAMigrations
{
    [DbContext(typeof(WMBAContext))]
<<<<<<<< HEAD:WMBA5/WMBA5/Data/WMBAMigrations/20240304221436_Initial.Designer.cs
    [Migration("20240304221436_Initial")]
========
    [Migration("20240304213359_Initial")]
>>>>>>>> 11e7f781d8cc9aac329319b52f774dec28b0b99e:WMBA5/WMBA5/Data/WMBAMigrations/20240304213359_Initial.Designer.cs
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("WMBA5.Models.Club", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClubName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("WMBA5.Models.Coach", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoachName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("WMBA5.Models.Division", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClubID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("WMBA5.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwayTeamID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DivisionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HomeTeamID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OutcomeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AwayTeamID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("HomeTeamID");

                    b.HasIndex("LocationID");

                    b.HasIndex("OutcomeID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("WMBA5.Models.GamePlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamLineup")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.HasIndex("PlayerID", "GameID")
                        .IsUnique();

                    b.ToTable("GamePlayers");
                });

            modelBuilder.Entity("WMBA5.Models.Inning", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InningNo")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.ToTable("Innings");
                });

            modelBuilder.Entity("WMBA5.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocationName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WMBA5.Models.Outcome", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OutcomeString")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Outcomes");
                });

            modelBuilder.Entity("WMBA5.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DivisionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("JerseyNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int?>("StatusID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("MemberID")
                        .IsUnique();

                    b.HasIndex("StatusID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WMBA5.Models.PlayerAtBat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InningID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.HasIndex("InningID");

                    b.HasIndex("PlayerID");

                    b.ToTable("PlayerAtBat");
                });

            modelBuilder.Entity("WMBA5.Models.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("WMBA5.Models.Score", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Balls")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoulBalls")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hits")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InningID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Out")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Runs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Strikes")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.HasIndex("InningID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("WMBA5.Models.Stat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hits")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerAppearance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RBI")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RunsScored")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StrikeOuts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Walks")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("WMBA5.Models.Status", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("WMBA5.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CoachID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DivisionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CoachID");

                    b.HasIndex("DivisionID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("WMBA5.Models.Division", b =>
                {
                    b.HasOne("WMBA5.Models.Club", "Club")
                        .WithMany("Divisions")
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("WMBA5.Models.Game", b =>
                {
                    b.HasOne("WMBA5.Models.Team", "AwayTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Division", "Division")
                        .WithMany("Games")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Team", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Outcome", "Outcome")
                        .WithMany()
                        .HasForeignKey("OutcomeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("Division");

                    b.Navigation("HomeTeam");

                    b.Navigation("Location");

                    b.Navigation("Outcome");
                });

            modelBuilder.Entity("WMBA5.Models.GamePlayer", b =>
                {
                    b.HasOne("WMBA5.Models.Game", "Game")
                        .WithMany("GamePlayers")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Player", "Player")
                        .WithMany("GamePlayers")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("WMBA5.Models.Inning", b =>
                {
                    b.HasOne("WMBA5.Models.Game", "Game")
                        .WithMany("Innings")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("WMBA5.Models.Player", b =>
                {
                    b.HasOne("WMBA5.Models.Division", "Division")
                        .WithMany("Players")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID");

                    b.HasOne("WMBA5.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Division");

                    b.Navigation("Status");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WMBA5.Models.PlayerAtBat", b =>
                {
                    b.HasOne("WMBA5.Models.Game", "Game")
                        .WithMany("PlayerAtBats")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Inning", "Inning")
                        .WithMany()
                        .HasForeignKey("InningID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Player", "Player")
                        .WithMany("PlayerAtBats")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Inning");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("WMBA5.Models.Score", b =>
                {
                    b.HasOne("WMBA5.Models.Game", "Game")
                        .WithMany("Scores")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Inning", "Inning")
                        .WithMany("Scores")
                        .HasForeignKey("InningID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMBA5.Models.Player", "Player")
                        .WithMany("Scores")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Inning");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("WMBA5.Models.Stat", b =>
                {
                    b.HasOne("WMBA5.Models.Player", "Player")
                        .WithMany("Stats")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("WMBA5.Models.Team", b =>
                {
                    b.HasOne("WMBA5.Models.Coach", "Coach")
                        .WithMany("Teams")
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("WMBA5.Models.Division", "Division")
                        .WithMany("Teams")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Division");
                });

            modelBuilder.Entity("WMBA5.Models.Club", b =>
                {
                    b.Navigation("Divisions");
                });

            modelBuilder.Entity("WMBA5.Models.Coach", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("WMBA5.Models.Division", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Players");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("WMBA5.Models.Game", b =>
                {
                    b.Navigation("GamePlayers");

                    b.Navigation("Innings");

                    b.Navigation("PlayerAtBats");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("WMBA5.Models.Inning", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("WMBA5.Models.Player", b =>
                {
                    b.Navigation("GamePlayers");

                    b.Navigation("PlayerAtBats");

                    b.Navigation("Scores");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("WMBA5.Models.Team", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
