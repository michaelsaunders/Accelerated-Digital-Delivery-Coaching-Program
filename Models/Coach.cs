using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Coach
    {
        public Guid CoachID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Person> Person {get; set;}
    }
}
