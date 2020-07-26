using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class TeamInteration
    {
        [Key]
        public Guid TeamIterationID { get; set; }

        public Iteration IterationID { get; set; }

        public Team TeamID { get; set; }
    }
}
