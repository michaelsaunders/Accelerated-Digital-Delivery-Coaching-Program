using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProductBacklog
    {
        public Guid ProductBacklogID { get; set; }

        public string ProductBacklogName { get; set; }

        public string ProductDefintionOfDone { get; set; }

        public ICollection<ProductBacklogItem> ProductBacklogItems { get; set; }

    }
}
