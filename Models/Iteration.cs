using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Iteration
    {
        public Guid IterationID { get; set; }

        [DisplayName("Iteration / Sprint Name")]
        public string IterationName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DisplayName("Stop Date")]
        public DateTime StopDate { get; set; }


        public long TeamID { get; set; }
            
        public ProgramIncrement ProgramIncrement { get; set; }

        public Team Team { get; set; }

        [DisplayName("Completed Work")]
        public int CompletedWork { get; set; }

        [DisplayName("Committed Work")]
        public int CommittedWork { get; set; }

        public Guid IterationGoalID { get; set; }

        public IterationGoal IterationGoal { get; set; }

    }
}
