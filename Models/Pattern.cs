using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Pattern
    {
        public Guid PatternID { get; set; }

        public string PatternName { get; set; }

        public string InputToPattern { get; set; }

        public string OutToPattern { get; set; }


    }
}
