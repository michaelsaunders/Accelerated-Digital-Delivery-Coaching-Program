using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class CoachingContract
    {
        public Guid CoachingContractID { get; set; }

        public Person Person { get; set; }

        
        public String FreeFormNotes { get; set; }
    }
}
