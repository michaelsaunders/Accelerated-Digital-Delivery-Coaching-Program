using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Iteration
    {
        public Guid IterationID { get; set; }
        public string IterationName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }

        public long TeamID { get; set; }
            
        public ProgramIncrement ProgramIncrement { get; set; }

        public Team Team { get; set; }

        public int CompletedWork { get; set; }

        public int CommittedWork { get; set; }

        public Guid IterationGoalID { get; set; }

        public IterationGoal IterationGoal { get; set; }

    }
}
