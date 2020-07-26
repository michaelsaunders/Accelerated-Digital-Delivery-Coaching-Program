﻿// <auto-generated />
using System;
using Accelerated_Digital_Delivery_Coaching_Program.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    [DbContext(typeof(AddDBContext))]
    [Migration("20200724192136_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Iteration", b =>
                {
                    b.Property<Guid>("IterationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("InterationNumber")
                        .HasColumnType("int");

                    b.Property<string>("IterationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProgramIncrementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IterationID");

                    b.HasIndex("ProgramIncrementID");

                    b.ToTable("Iterations");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.OKR", b =>
                {
                    b.Property<Guid>("OkrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ConfidenceScoreMeasure1")
                        .HasColumnType("int");

                    b.Property<int>("ConfidenceScoreMeasure2")
                        .HasColumnType("int");

                    b.Property<int>("ConfidenceScoreMeasure3")
                        .HasColumnType("int");

                    b.Property<int>("ConfidenceScoreMeasure4")
                        .HasColumnType("int");

                    b.Property<int>("ConfidenceScoreMeasure5")
                        .HasColumnType("int");

                    b.Property<string>("Measure1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measure2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measure3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measure4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measure5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MetricMeasure1")
                        .HasColumnType("bigint");

                    b.Property<long>("MetricMeasure2")
                        .HasColumnType("bigint");

                    b.Property<long>("MetricMeasure3")
                        .HasColumnType("bigint");

                    b.Property<long>("MetricMeasure4")
                        .HasColumnType("bigint");

                    b.Property<long>("MetricMeasure5")
                        .HasColumnType("bigint");

                    b.Property<string>("Objective")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OkrID");

                    b.ToTable("OKRs");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Pattern", b =>
                {
                    b.Property<Guid>("PatternID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InputToPattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutToPattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatternName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatternID");

                    b.ToTable("Patterns");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", b =>
                {
                    b.Property<long>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklog", b =>
                {
                    b.Property<Guid>("ProductBacklogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductBacklogName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDefintionOfDone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductBacklogID");

                    b.ToTable("ProductBacklog");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklogItem", b =>
                {
                    b.Property<Guid>("ProductBacklogItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcceptanceCriteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComparativePoints")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductBacklogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductBacklogItemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductBacklogItemId");

                    b.HasIndex("ProductBacklogId");

                    b.ToTable("ProductBacklogItem");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", b =>
                {
                    b.Property<Guid>("ProgramIncrementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncrementID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TeamOfTeamsTeamOfTeamID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProgramIncrementID");

                    b.HasIndex("TeamOfTeamsTeamOfTeamID");

                    b.ToTable("ProgramIncrements");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Sequence", b =>
                {
                    b.Property<Guid>("SequenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SequenceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SequenceID");

                    b.ToTable("Sequences");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TaskItem", b =>
                {
                    b.Property<Guid>("TaskItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Occurence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskItemID");

                    b.ToTable("TaskItem");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Team", b =>
                {
                    b.Property<long>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastYesterdaysWeatherUpdate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("TeamCoachPersonID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TeamLeadPersonID")
                        .HasColumnType("bigint");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YesterdaysWeather")
                        .HasColumnType("int");

                    b.HasKey("TeamID");

                    b.HasIndex("TeamCoachPersonID");

                    b.HasIndex("TeamLeadPersonID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeam", b =>
                {
                    b.Property<Guid>("TeamOfTeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamOfTeamsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamOfTeamID");

                    b.ToTable("TeamOfTeams");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamSequence", b =>
                {
                    b.Property<Guid>("TeamSequenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamSequenceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamSequenceID");

                    b.ToTable("TeamSequences");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamSprint", b =>
                {
                    b.Property<Guid>("TeamSprintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SprintID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeamID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeamSprintID");

                    b.ToTable("TeamSprint");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Iteration", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", "ProgramIncrement")
                        .WithMany()
                        .HasForeignKey("ProgramIncrementID");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklogItem", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklog", "ProductBacklog")
                        .WithMany("ProductBacklogItems")
                        .HasForeignKey("ProductBacklogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeam", "TeamOfTeams")
                        .WithMany()
                        .HasForeignKey("TeamOfTeamsTeamOfTeamID");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Team", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "TeamCoach")
                        .WithMany()
                        .HasForeignKey("TeamCoachPersonID");

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "TeamLead")
                        .WithMany()
                        .HasForeignKey("TeamLeadPersonID");
                });
#pragma warning restore 612, 618
        }
    }
}
