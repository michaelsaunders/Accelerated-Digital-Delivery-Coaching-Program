using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class TeamSprint
    {
        public Guid TeamSprintID { get; set; }

        public Guid SprintID { get; set; }

        public Guid TeamID { get; set; }
    }
}
