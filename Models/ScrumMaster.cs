using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ScrumMaster
    {
        public Guid ScrumMasterID { get; set; }

        public long PersonID { get; set; }
        public Person Person { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }
        
        public Team? Team { get; set;}

        //People 
        //Process
        //Technology
        //Quality

        [DisplayName("Above / Middle / Below")]
        public string Coaching { get; set; }

        [DisplayName("Velocity is Improving")]
        public Boolean Velocity { get; set; }

        [DisplayName("Team Happiness")]
        public Boolean TeamHappiness { get; set; }

        [DisplayName("Quality")]
        public Boolean Quality { get; set; }

        [DisplayName("Process Efficiency")]
        public Boolean ProcessEfficiency { get; set; }


        [DisplayName("Business Value Per Story Point")]
        public Boolean BusinessValuePerStoryPoint { get; set; }

        [DisplayName("Next Appointment")]
        public DateTime NextAppointment { get; set; }

        [DisplayName("Personal Improvement")]
        public Boolean PersonalImprovement { get; set; }


    }
}
