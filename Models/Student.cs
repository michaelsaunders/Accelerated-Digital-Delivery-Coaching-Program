using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class Student
    {
        public Guid StudentID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String EmailAddress { get; set; }


    }
}
