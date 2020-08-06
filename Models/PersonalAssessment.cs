using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class PersonalAssessment
    {
        public Guid PersonalAssessmentID { get; set; }

        public long PersonID { get; set;  }

        public Person Person { get; set; }

        [DisplayName("Assessment Name / Reason")]
        public string AssessmentName { get; set; }

        [DisplayName("What Date Did We Load the Assessment")]
        public DateTime DateOfAssessment { get; set; }

        [DisplayName("What area are we coaching")]
        public AreasOfCoaching AreaCoaching { get; set; }

        public enum AreasOfCoaching {
            [Display(Name="Leadership Coaching")]
            LeadershipCoaching,
            [Display(Name = "Health Coaching")]
            HealthCoaching,
            [Display(Name = "Career Coaching")]
            CareerCoaching,
            [Display(Name = "Spiritual Coaching")]
            SpiritualCoaching,
            [Display(Name = "Business Coaching")]
            BusinessCoaching,
            [Display(Name = "Relationship Coaching")]
            RelationshipCoaching,
        }

        [DisplayName("Did we have any notes we want to keep")]
        public string NotesForAssessment { get; set; }

        [DisplayName("Summary of Result")]
        public string SummaryResult { get; set; }

        public Guid PersonalAssessmentTemplateID { get; set; }
        public PersonalAssessmentTemplate PersonalAssessmentTemplate { get; set; }

        [DisplayName("What Date Should We Refresh The Assessmnet (IF NEEDED)")]
        public DateTime NextAsessmentDate { get; set; }
    }
}
