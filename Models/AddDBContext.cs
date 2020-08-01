using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Accelerated_Digital_Delivery_Coaching_Program.Models;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class AddDBContext : DbContext
    {
        public AddDBContext(DbContextOptions<AddDBContext> options)
           : base(options)
        {

        }


        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Sequence> Sequences { get; set; }

        public DbSet<TeamOfTeam> TeamOfTeams { get; set; }

        public DbSet<TeamSequence> TeamSequences { get; set; }

        public DbSet<ProgramIncrement> ProgramIncrements { get; set; }

        public DbSet<Iteration> Iterations { get; set; }

        public DbSet<OKR> OKRs { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.TeamSprint> TeamSprint { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.TaskItem> TaskItem { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklogItem> ProductBacklogItem { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.ProductBacklog> ProductBacklog { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.IterationGoal> IterationGoal { get; set; }

        public DbSet<Accelerated_Digital_Delivery_Coaching_Program.Models.ProgramIncrementGoal> ProgramIncrementGoal { get; set; }


    }
}
