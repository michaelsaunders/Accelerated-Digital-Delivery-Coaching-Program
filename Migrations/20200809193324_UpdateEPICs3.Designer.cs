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
    [Migration("20200809193324_UpdateEPICs3")]
    partial class UpdateEPICs3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Coach", b =>
                {
                    b.Property<Guid>("CoachID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoachID");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Epic", b =>
                {
                    b.Property<Guid>("EpicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ActualStoryPoints")
                        .HasColumnType("int");

                    b.Property<string>("CustomerIdentifierID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EpicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstimatedStoryPoints")
                        .HasColumnType("int");

                    b.Property<long?>("TeamID")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("TeamofTeamID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EpicID");

                    b.ToTable("Epic");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.InterestingSalesFacts", b =>
                {
                    b.Property<Guid>("InterestingSalesFactsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestingSalesFactsID");

                    b.ToTable("InterestingSalesFacts");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Iteration", b =>
                {
                    b.Property<Guid>("IterationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CommittedWork")
                        .HasColumnType("int");

                    b.Property<int>("CompletedWork")
                        .HasColumnType("int");

                    b.Property<Guid>("IterationGoalID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IterationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProgramIncrementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("TeamID")
                        .HasColumnType("bigint");

                    b.HasKey("IterationID");

                    b.HasIndex("IterationGoalID")
                        .IsUnique();

                    b.HasIndex("ProgramIncrementID");

                    b.HasIndex("TeamID");

                    b.ToTable("Iterations");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.IterationGoal", b =>
                {
                    b.Property<Guid>("IterationGoalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Achievable")
                        .HasColumnType("bit");

                    b.Property<int>("CurrentStatus")
                        .HasColumnType("int");

                    b.Property<int>("FistOfFive")
                        .HasColumnType("int");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Measurable")
                        .HasColumnType("bit");

                    b.Property<bool>("Realistic")
                        .HasColumnType("bit");

                    b.Property<bool>("Specific")
                        .HasColumnType("bit");

                    b.Property<bool>("TiedToOKR")
                        .HasColumnType("bit");

                    b.Property<bool>("Timebound")
                        .HasColumnType("bit");

                    b.HasKey("IterationGoalID");

                    b.ToTable("IterationGoal");
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

                    b.Property<string>("BriefDescription")
                        .HasColumnType("nvarchar(160)")
                        .HasMaxLength(160);

                    b.Property<string>("FullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InputToPattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutToPattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatternName")
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("PatternID");

                    b.ToTable("Patterns");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PatternAssessment", b =>
                {
                    b.Property<Guid>("PatternAssessmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FollowUpCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Implemented")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NextAssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatternID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RatingOfAssessment")
                        .HasColumnType("int");

                    b.Property<bool>("RecordActive")
                        .HasColumnType("bit");

                    b.Property<long>("TeamID")
                        .HasColumnType("bigint");

                    b.Property<bool>("WithIntent")
                        .HasColumnType("bit");

                    b.HasKey("PatternAssessmentID");

                    b.ToTable("PatternAssessment");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", b =>
                {
                    b.Property<long>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("CoachID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NextAppointment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NextAssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.HasIndex("CoachID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonNote", b =>
                {
                    b.Property<Guid>("PersonNoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonID")
                        .HasColumnType("bigint");

                    b.HasKey("PersonNoteID");

                    b.HasIndex("PersonID");

                    b.ToTable("PersonNote");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonalAssessment", b =>
                {
                    b.Property<Guid>("PersonalAssessmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AreaCoaching")
                        .HasColumnType("int");

                    b.Property<string>("AssessmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfAssessment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NextAsessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotesForAssessment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonID")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PersonalAssessmentTemplateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SummaryResult")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalAssessmentID");

                    b.HasIndex("PersonID");

                    b.HasIndex("PersonalAssessmentTemplateID");

                    b.ToTable("PersonalAssessment");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonalAssessmentTemplate", b =>
                {
                    b.Property<Guid>("PersonalAssessmentTemplateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AreaOfCoaching")
                        .HasColumnType("int");

                    b.Property<string>("BriefDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailedDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToPDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalAssessmentTemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalAssessmentTemplateID");

                    b.ToTable("PersonalAssessmentTemplate");
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

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrementGoal", b =>
                {
                    b.Property<Guid>("ProgramIncrementGoalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("AcheivedValue")
                        .HasColumnType("bigint");

                    b.Property<bool>("Achievable")
                        .HasColumnType("bit");

                    b.Property<long>("BusinessValue")
                        .HasColumnType("bigint");

                    b.Property<bool>("CommittedGoal")
                        .HasColumnType("bit");

                    b.Property<int>("CurrentStatus")
                        .HasColumnType("int");

                    b.Property<int>("FistOfFive")
                        .HasColumnType("int");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Measurable")
                        .HasColumnType("bit");

                    b.Property<string>("Measure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProgramIncrementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Realistic")
                        .HasColumnType("bit");

                    b.Property<bool>("Specific")
                        .HasColumnType("bit");

                    b.Property<long>("TeamID")
                        .HasColumnType("bigint");

                    b.Property<bool>("TiedToOKR")
                        .HasColumnType("bit");

                    b.Property<bool>("Timebound")
                        .HasColumnType("bit");

                    b.HasKey("ProgramIncrementGoalID");

                    b.HasIndex("ProgramIncrementID");

                    b.ToTable("ProgramIncrementGoal");
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

                    b.Property<Guid?>("PatternID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("TeamCoachPersonID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TeamLeadPersonID")
                        .HasColumnType("bigint");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeamOfTeamIterationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("YesterdaysWeather")
                        .HasColumnType("int");

                    b.HasKey("TeamID");

                    b.HasIndex("PatternID");

                    b.HasIndex("TeamCoachPersonID");

                    b.HasIndex("TeamLeadPersonID");

                    b.HasIndex("TeamOfTeamIterationID");

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

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeamIteration", b =>
                {
                    b.Property<Guid>("TeamOfTeamIterationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("IncrementCommittedVelocity")
                        .HasColumnType("bigint");

                    b.Property<long?>("IncrementDeliveredVelocity")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ProgramIncrementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TeamOfTeamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TeamOfTeamIterationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("YesterdaysWeather")
                        .HasColumnType("bigint");

                    b.HasKey("TeamOfTeamIterationID");

                    b.HasIndex("ProgramIncrementID");

                    b.HasIndex("TeamOfTeamID");

                    b.ToTable("TeamOfTeamIteration");
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
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.IterationGoal", "IterationGoal")
                        .WithOne("Iteration")
                        .HasForeignKey("Accelerated_Digital_Delivery_Coaching_Program.Models.Iteration", "IterationGoalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", "ProgramIncrement")
                        .WithMany("Iterations")
                        .HasForeignKey("ProgramIncrementID");

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Coach", null)
                        .WithMany("Person")
                        .HasForeignKey("CoachID");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonNote", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "Person")
                        .WithMany("PersonNotes")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonalAssessment", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "Person")
                        .WithMany("PersonalAssessments")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.PersonalAssessmentTemplate", "PersonalAssessmentTemplate")
                        .WithMany()
                        .HasForeignKey("PersonalAssessmentTemplateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrementGoal", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", "ProgramIncrement")
                        .WithMany("ProgramIncrementGoals")
                        .HasForeignKey("ProgramIncrementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.Team", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Pattern", "Pattern")
                        .WithMany()
                        .HasForeignKey("PatternID");

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "TeamCoach")
                        .WithMany()
                        .HasForeignKey("TeamCoachPersonID");

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.Person", "TeamLead")
                        .WithMany()
                        .HasForeignKey("TeamLeadPersonID");

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeamIteration", null)
                        .WithMany("Teams")
                        .HasForeignKey("TeamOfTeamIterationID");
                });

            modelBuilder.Entity("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeamIteration", b =>
                {
                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrement", "ProgramIncrement")
                        .WithMany()
                        .HasForeignKey("ProgramIncrementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accelerated_Digital_Delivery_Coaching_Program.Models.TeamOfTeam", null)
                        .WithMany("TeamOfTeamIterations")
                        .HasForeignKey("TeamOfTeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
