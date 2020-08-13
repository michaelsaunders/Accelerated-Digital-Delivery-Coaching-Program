using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProgramIncrementGoal
    {
        public Guid ProgramIncrementGoalID { get; set; }

        [DisplayName("Program Increment Goal")]
        public string Goal { get; set; }

        [DisplayName("What is the measure?")]
        public string Measure { get; set; }

        public Boolean Specific { get; set; }

        public Boolean Measurable { get; set; }

        public Boolean Achievable { get; set; }

        public Boolean Realistic { get; set; }

        public Boolean Timebound { get; set; }

        public Boolean TiedToOKR { get; set; }

        public long TeamID { get; set; }

        public long BusinessValue { get; set; }

        public long AcheivedValue { get; set;  }

        public Boolean CommittedGoal { get; set; }

        public int FistOfFive { get; set; }

        public int CurrentStatus { get; set; }

        public Guid ProgramIncrementID { get; set; }
        public ProgramIncrement ProgramIncrement { get; set; }
    }
}
