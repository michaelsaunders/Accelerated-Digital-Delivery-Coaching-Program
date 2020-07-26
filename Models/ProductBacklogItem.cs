using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProductBacklogItem
    {
        public Guid ProductBacklogItemId { get; set; }

        public string ProductBacklogItemName { get; set; }

        public string AcceptanceCriteria { get; set; }

        public int ComparativePoints { get; set; }

       


        public Guid ProductBacklogId { get; set; }
        public ProductBacklog ProductBacklog { get; set; }

    }
}
