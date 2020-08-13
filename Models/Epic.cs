using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Epic
    {
        public Guid EpicID { get; set; }
        public string EpicName { get; set; }
        public string CustomerIdentifierID { get; set; }

        public int? EstimatedStoryPoints { get; set; }

        public int? ActualStoryPoints { get; set; }
        public Guid? TeamofTeamID { get; set; }

        public long? TeamID { get; set; }

        public Guid? ProgramIncrementID { get; set; }
    }
}
