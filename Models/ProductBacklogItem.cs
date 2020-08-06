using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accelerated_Digital_Delivery_Coaching_Program.Models
{
    public class ProductBacklogItem
    {
        public Guid ProductBacklogItemId { get; set; }

        [DisplayName("Product Backlog Item Name")]
        public string ProductBacklogItemName { get; set; }

        [DisplayName("Acceptance Criteria")]
        public string AcceptanceCriteria { get; set; }

        [DisplayName("Comparative Points")]
        public int ComparativePoints { get; set; }

       


        public Guid ProductBacklogId { get; set; }
        public ProductBacklog ProductBacklog { get; set; }

    }
}
