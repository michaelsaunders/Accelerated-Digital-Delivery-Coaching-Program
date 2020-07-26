using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class IterationGoal
    {
        public Guid IterationGoalID { get; set; }

        public string Goal { get; set; }

        public Boolean Specific { get; set; }

        public Boolean Measurable { get; set; }

        public Boolean Achievable { get; set;  }

        public Boolean Realistic { get; set; }

        public Boolean Timebound { get; set; }

        public Boolean TiedToOKR { get; set; }

        public Iteration Iteration { get; set; }
    }
}
