using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Pattern
    {
        public Guid PatternID { get; set; }

        [MaxLength(80)]
        [DisplayName("Pattern Name")]
        [StringLength(80, ErrorMessage = "The Pattern Name cannot exceed 80 characters. ")]
        public string PatternName { get; set; }

        [MaxLength(160)]
        [DisplayName("Brief Description")]
        [StringLength(160, ErrorMessage = "The brief description cannot exceed 160 characters. ")]
        public string BriefDescription { get; set; }

        [DisplayName("Full Description")]
        public string FullDescription { get; set; }

        [DisplayName("Input Into Pattern")]
        public string InputToPattern { get; set; }

        [DisplayName("Output Of Pattern")]
        public string OutToPattern { get; set; }

        

    }
}
