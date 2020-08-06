using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class PersonalAssessmentTemplate
    {
        public Guid PersonalAssessmentTemplateID { get; set; }


        [DisplayName("Personal Assessment Template Name")]
        public string PersonalAssessmentTemplateName { get; set; }

        [DisplayName("Area of Coaching")]
        public AreasOfCoaching AreaOfCoaching { get; set; }


        public enum AreasOfCoaching
        {
            [Description("Leadership Coaching")]
            LeadershipCoaching,
            [Description("Health Coaching")]
            HealthCoaching,
            [Description("Career Coaching")]
            CareerCoaching,
            [Description("Spiritual Coaching")]
            SpiritualCoaching,
            [Description("Business Coaching")]
            BusinessCoaching,
            [Description("Relationship Coaching")]
            RelationshipCoaching,
        }

        [DisplayName("Link To PDF")]
        public string LinkToPDF { get; set; }

        [DisplayName("Brief Description")]
        public string BriefDescription { get; set; }

        [DisplayName("Detailed Description")]
        public string DetailedDescription { get; set; }

        [DisplayName("Link To Image")]
        public string LinkToImage { get; set; }


    }
}