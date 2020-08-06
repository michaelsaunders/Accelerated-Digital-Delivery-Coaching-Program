using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class TeamOfTeam
    {
        public Guid TeamOfTeamID { get; set; }

        [DisplayName("Team Of Teams Name")]
        public string TeamOfTeamsName { get; set; }
    }
}
