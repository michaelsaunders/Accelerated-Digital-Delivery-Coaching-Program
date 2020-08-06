using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class PersonNote
    {
        public Guid PersonNoteID { get; set; }


        [DisplayName("What Day Did We Take The Notes")]
        public DateTime NoteDate { get; set; }

        public long PersonID { get; set; }
        public Person Person { get; set; }

        [DisplayName("What did we want to record")]
        public String Notes { get; set; }
    }
}
