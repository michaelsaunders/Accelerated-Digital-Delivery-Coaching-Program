using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class PatternAssessment
    {
        public Guid PatternAssessmentID { get; set; }

        [DisplayName("Team Id")]
        public long TeamID { get; set; }

        public Guid PatternID { get; set; }

        [DisplayName("Pattern is Implemented")]
        public Boolean Implemented { get; set;  }

        [DisplayName("Implemented With Intention")]
        public Boolean WithIntent { get; set; }
        
        public enum Rating
        {
            [Description("Under Performing")]
            Underperforming,
            [Description("Good Performance")]
            Goodperformance,
            [Description("High Performance")]
            Highperforming
        }

        [DisplayName("Rating For The Pattern")]
        public Rating RatingOfAssessment { get; set; }


        [DisplayName("Notes from Assessor")]
        public string Notes {get;set;}

        [DisplayName("When was the Assessment Done")]
        public DateTime AssessmentDate { get; set; }

        [DisplayName("When will the next assessment be done")]
        public DateTime NextAssessmentDate { get; set; }

        [DisplayName("Has the followup been completed")]
        public Boolean FollowUpCompleted { get; set; }

        [DisplayName("Is the record active")]
        public Boolean RecordActive { get; set; }
    }
}
