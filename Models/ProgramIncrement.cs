using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProgramIncrement
    {
        public Guid ProgramIncrementID { get; set; }

        [DisplayName("Program Increment ID")]
        public int IncrementID { get; set; }

        [DisplayName("Start of Program Increment")]
        public DateTime StartDate { get; set; }

        [DisplayName("End of Program Increment")]
        public DateTime EndDate { get; set; }

        public TeamOfTeam? TeamOfTeams { get;set;}

        public Team? Teams { get; set; }
        public ICollection<ProgramIncrementGoal> ProgramIncrementGoals { get; set; }
        public ICollection<Iteration> Iterations { get; set; }

    }
}
