using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class TeamOfTeamIteration
    {

        public Guid TeamOfTeamIterationID { get; set; }


        public Guid TeamOfTeamID { get; set; }

        [DisplayName("Iteration / Sprint Name")]
        public string TeamOfTeamIterationName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DisplayName("Stop Date")]
        public DateTime StopDate { get; set; }
        
        [DisplayName("Program Increment ID")]
        public Guid ProgramIncrementID { get; set; }

        public ProgramIncrement ProgramIncrement { get; set; }

        public ICollection<Team> Teams { get; set; }

        public long? YesterdaysWeather { get; set; }

        public long? IncrementCommittedVelocity { get; set; }

        public long? IncrementDeliveredVelocity { get; set; }

        public int? IterationConfidence { get; set; }
    }
}
