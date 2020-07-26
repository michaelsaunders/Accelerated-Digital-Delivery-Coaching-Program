using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProgramIncrement
    {
        public Guid ProgramIncrementID { get; set; }
        public int IncrementID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TeamOfTeam TeamOfTeams { get;set;}



    }
}
