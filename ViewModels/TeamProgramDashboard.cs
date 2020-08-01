using Accelerated_Digital_Delivery_Coaching_Program.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.ViewModels
{
    public class TeamProgramDashboard
    {
        
        public Team Team { get; set; }

        public ProgramIncrement ProgramIncrement { get; set; }
        
        public ICollection<ProgramIncrementGoal> ProgramIncrementGoals { get; set; } 

        public ICollection<Iteration> Iterations { get; set; }

    }
}
